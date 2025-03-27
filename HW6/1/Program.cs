using System.Text;

namespace _1
{
    public class OrderDetail
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal TotalAmount => Price * Quantity;

        public override bool Equals(object obj)
        {
            return obj is OrderDetail detail &&
                   ProductName == detail.ProductName &&
                   Price == detail.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ProductName, Price);
        }

        public override string ToString()
        {
            return $"产品:{ProductName}, 单价:{Price:C}, 数量:{Quantity}, 小计:{TotalAmount:C}";
        }
    }
    public class Order : IComparable<Order>
    {
        public string OrderId { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> Details { get; set; } = new List<OrderDetail>();

        public decimal TotalAmount => Details.Sum(d => d.TotalAmount);

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderId);
        }

        public int CompareTo(Order other)
        {
            return OrderId.CompareTo(other.OrderId);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"订单号:{OrderId}, 客户:{Customer}, 日期:{OrderDate:yyyy-MM-dd}, 总金额:{TotalAmount:C}");
            sb.AppendLine("订单明细:");
            foreach (var detail in Details)
            {
                sb.AppendLine("  " + detail.ToString());
            }
            return sb.ToString();
        }
    }
    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        // 添加订单
        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
            {
                throw new ArgumentException("订单已存在!");
            }
            orders.Add(order);
        }

        // 删除订单
        public void RemoveOrder(string orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                throw new ArgumentException("订单不存在!");
            }
            orders.Remove(order);
        }

        // 修改订单
        public void UpdateOrder(Order order)
        {
            var existing = orders.FirstOrDefault(o => o.OrderId == order.OrderId);
            if (existing == null)
            {
                throw new ArgumentException("订单不存在!");
            }
            orders.Remove(existing);
            orders.Add(order);
        }

        // 查询所有订单
        public List<Order> GetAllOrders()
        {
            return orders.OrderBy(o => o.OrderId).ToList();
        }

        // 按订单号查询
        public List<Order> QueryByOrderId(string orderId)
        {
            return orders.Where(o => o.OrderId.Contains(orderId))
                        .OrderBy(o => o.TotalAmount)
                        .ToList();
        }

        // 按产品名称查询
        public List<Order> QueryByProductName(string productName)
        {
            return orders.Where(o => o.Details.Any(d => d.ProductName.Contains(productName)))
                        .OrderBy(o => o.TotalAmount)
                        .ToList();
        }

        // 按客户查询
        public List<Order> QueryByCustomer(string customer)
        {
            return orders.Where(o => o.Customer.Contains(customer))
                        .OrderBy(o => o.TotalAmount)
                        .ToList();
        }

        // 按金额范围查询
        public List<Order> QueryByAmountRange(decimal min, decimal max)
        {
            return orders.Where(o => o.TotalAmount >= min && o.TotalAmount <= max)
                        .OrderBy(o => o.TotalAmount)
                        .ToList();
        }

        // 自定义排序
        public List<Order> SortOrders(Func<Order, object> keySelector)
        {
            return orders.OrderBy(keySelector).ToList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var service = new OrderService();

            // 添加示例订单
            try
            {
                var order1 = new Order
                {
                    OrderId = "20230001",
                    Customer = "张三",
                    OrderDate = DateTime.Now,
                    Details = new List<OrderDetail>
                {
                    new OrderDetail { ProductName = "笔记本电脑", Price = 5999, Quantity = 1 },
                    new OrderDetail { ProductName = "鼠标", Price = 99, Quantity = 2 }
                }
                };

                var order2 = new Order
                {
                    OrderId = "20230002",
                    Customer = "李四",
                    OrderDate = DateTime.Now,
                    Details = new List<OrderDetail>
                {
                    new OrderDetail { ProductName = "手机", Price = 3999, Quantity = 1 },
                    new OrderDetail { ProductName = "耳机", Price = 299, Quantity = 1 }
                }
                };

                service.AddOrder(order1);
                service.AddOrder(order2);
            }
            catch (Exception e)
            {
                Console.WriteLine($"添加订单错误: {e.Message}");
            }

            // 查询示例
            Console.WriteLine("所有订单:");
            foreach (var order in service.GetAllOrders())
            {
                Console.WriteLine(order);
            }

            Console.WriteLine("\n查询包含'手机'的订单:");
            foreach (var order in service.QueryByProductName("手机"))
            {
                Console.WriteLine(order);
            }

            // 测试异常处理
            try
            {
                service.RemoveOrder("999999");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n删除订单错误: {e.Message}");
            }
        }
    }
}