using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Polly;
using Polly.Retry;

public class AdvancedWebCrawler
{
    private readonly HttpClient _httpClient;
    private readonly AsyncRetryPolicy _retryPolicy;
    private readonly ConcurrentBag<CrawlResult> _results;
    private readonly int _maxDegreeOfParallelism;

    public AdvancedWebCrawler(int maxDegreeOfParallelism = 10)
    {
        // 配置HttpClient最佳实践
        var handler = new HttpClientHandler
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            UseCookies = false,
            MaxConnectionsPerServer = maxDegreeOfParallelism
        };

        _httpClient = new HttpClient(handler)
        {
            Timeout = TimeSpan.FromSeconds(30),
            DefaultRequestHeaders =
            {
                { "User-Agent", "Mozilla/5.0 (compatible; AdvancedWebCrawler/1.0)" },
                { "Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8" },
                { "Accept-Encoding", "gzip, deflate" }
            }
        };

        // 配置重试策略
        _retryPolicy = Policy
            .Handle<HttpRequestException>()
            .Or<TaskCanceledException>()
            .WaitAndRetryAsync(3, retryAttempt =>
                TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

        _results = new ConcurrentBag<CrawlResult>();
        _maxDegreeOfParallelism = maxDegreeOfParallelism;
    }

    public async Task<IReadOnlyCollection<CrawlResult>> CrawlAsync(IEnumerable<string> urls)
    {
        var tasks = new List<Task>();
        var throttler = new SemaphoreSlim(_maxDegreeOfParallelism);

        foreach (var url in urls)
        {
            await throttler.WaitAsync();
            tasks.Add(Task.Run(async () =>
            {
                try
                {
                    var result = await CrawlUrlAsync(url);
                    _results.Add(result);
                }
                finally
                {
                    throttler.Release();
                }
            }));
        }

        await Task.WhenAll(tasks);
        return _results.ToList();
    }

    private async Task<CrawlResult> CrawlUrlAsync(string url)
    {
        return await _retryPolicy.ExecuteAsync(async () =>
        {
            try
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var html = await response.Content.ReadAsStringAsync();
                var doc = new HtmlDocument();
                doc.LoadHtml(html);

                var title = doc.DocumentNode.SelectSingleNode("//title")?.InnerText.Trim() ?? "无标题";
                var description = doc.DocumentNode
                    .SelectSingleNode("//meta[@name='description']")?
                    .GetAttributeValue("content", null);

                var links = doc.DocumentNode
                    .SelectNodes("//a[@href]")?
                    .Select(a => a.GetAttributeValue("href", null))
                    .Where(href => !string.IsNullOrEmpty(href))
                    .ToList() ?? new List<string>();

                stopwatch.Stop();

                return new CrawlResult
                {
                    Url = url,
                    Title = title,
                    Description = description,
                    Links = links,
                    StatusCode = response.StatusCode,
                    ResponseTimeMs = stopwatch.ElapsedMilliseconds,
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new CrawlResult
                {
                    Url = url,
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        });
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}

public class CrawlResult
{
    public string Url { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<string> Links { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public long ResponseTimeMs { get; set; }
    public bool Success { get; set; }
    public string ErrorMessage { get; set; }
}

// 使用示例
class Program
{
    static async Task Main(string[] args)
    {
        var urls = new List<string>
        {
            "https://www.microsoft.com",
            "https://www.google.com",
            "https://www.github.com",
            "https://www.stackoverflow.com",
            "https://www.amazon.com",
            "https://www.reddit.com",
            "https://www.twitter.com",
            "https://www.linkedin.com"
        };

        Console.WriteLine("开始爬取...");
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        using (var crawler = new AdvancedWebCrawler(maxDegreeOfParallelism: 8))
        {
            var results = await crawler.CrawlAsync(urls);

            Console.WriteLine($"\n爬取完成！耗时: {stopwatch.Elapsed.TotalSeconds:F2}秒");
            Console.WriteLine($"成功: {results.Count(r => r.Success)} | 失败: {results.Count(r => !r.Success)}");

            foreach (var result in results.Where(r => r.Success).Take(3))
            {
                Console.WriteLine($"\nURL: {result.Url}");
                Console.WriteLine($"标题: {result.Title}");
                Console.WriteLine($"描述: {result.Description?.Substring(0, Math.Min(100, result.Description.Length))}...");
                Console.WriteLine($"响应时间: {result.ResponseTimeMs}ms");
                Console.WriteLine($"发现链接数: {result.Links.Count}");
            }
        }
    }
}