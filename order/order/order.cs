using System;
using System.Collections.Generic;
using System.Linq;
namespace order
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Product ID: {ProductId}, Name: {Name}, Price: {Price:C}";
        }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   ProductId == product.ProductId &&
                   Name == product.Name &&
                   Price == product.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ProductId, Name, Price);
        }
    }

    public class Customer
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }

        public override string ToString()
        {
            return $"Customer ID: {CustomerId}, Name: {Name}, Contact: {ContactInfo}";
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   CustomerId == customer.CustomerId &&
                   Name == customer.Name &&
                   ContactInfo == customer.ContactInfo;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CustomerId, Name, ContactInfo);
        }
    }

    public class OrderDetails
    {
        public int Quantity { get; set; }
        public decimal TotalPrice => Product.Price * Quantity;
        private Product _product;

        public Product Product
        {
            get => _product;
            set => _product = value ?? throw new ArgumentNullException(nameof(Product));
        }


        public override string ToString()
        {
            return $"{Product} x {Quantity} = {TotalPrice:C}";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   EqualityComparer<Product>.Default.Equals(Product, details.Product) &&
                   Quantity == details.Quantity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Product, Quantity);
        }
    }

    public class Order : IComparable<Order>
    {
        public string OrderId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetails> Details { get; set; } = new List<OrderDetails>();
        public decimal TotalAmount => Details.Sum(d => d.TotalPrice);

        public override string ToString()
        {
            return $"Order ID: {OrderId}\nCustomer: {Customer}\nDate: {OrderDate:yyyy-MM-dd}\n" +
                   $"Details:\n{string.Join("\n", Details)}\nTotal: {TotalAmount:C}";
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderId == order.OrderId &&
                   EqualityComparer<Customer>.Default.Equals(Customer, order.Customer) &&
                   OrderDate == order.OrderDate &&
                   Details.SequenceEqual(order.Details);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderId, Customer, OrderDate, Details);
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return OrderId.CompareTo(other.OrderId);
        }
    }
    public class OrderService
    {
        private readonly List<Order> orders = new List<Order>();

        // 添加订单
        public void AddOrder(Order order)
        {
            var orderDetail = new OrderDetails
            {
                Product = new Product(), // 必须初始化
                //{
                //    ProductId = "P001",
                //    Name = "Example Product",
                //    Price = 9.99m
                //},
                Quantity = 1
            };
            order.Details.Add(orderDetail);
            // 安全访问方式1：条件判断
            if (orderDetail.Product != null)
            {
                Console.WriteLine(orderDetail.Product.Name);
            }

            // 安全访问方式2：null条件运算符(C# 6.0+)
            Console.WriteLine(orderDetail.Product?.Name ?? "未知产品");
            //if (order == null)
            //    throw new ArgumentNullException(nameof(order), "Order cannot be null");

            if (orders.Any(o => o.OrderId == order.OrderId))
                throw new ArgumentException($"Order with ID {order.OrderId} already exists");

            if (order.Details.Count == 0)
                throw new ArgumentException("Order must have at least one detail");

            orders.Add(order);
        }

        // 删除订单
        public void RemoveOrder(string orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
                throw new ArgumentException($"Order with ID {orderId} not found");

            orders.Remove(order);
        }

        // 修改订单
        public void UpdateOrder(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order), "Order cannot be null");

            var existingOrder = orders.FirstOrDefault(o => o.OrderId == order.OrderId);
            if (existingOrder == null)
                throw new ArgumentException($"Order with ID {order.OrderId} not found");

            orders.Remove(existingOrder);
            orders.Add(order);
        }

        // 查询所有订单
        public List<Order> GetAllOrders()
        {
            return orders.OrderBy(o => o.TotalAmount).ToList();
        }

        // 按订单号查询
        public List<Order> QueryByOrderId(string orderId)
        {
            return orders.Where(o => o.OrderId.Contains(orderId))
                         .OrderBy(o => o.TotalAmount)
                         .ToList();
        }

        // 按客户查询
        public List<Order> QueryByCustomer(string customerName)
        {
            return orders.Where(o => o.Customer.Name.Contains(customerName))
                         .OrderBy(o => o.TotalAmount)
                         .ToList();
        }

        // 按商品名称查询
        public List<Order> QueryByProductName(string productName)
        {
            return orders.Where(o => o.Details.Any(d => d.Product.Name.Contains(productName)))
                         .OrderBy(o => o.TotalAmount)
                         .ToList();
        }

        // 按订单金额范围查询
        public List<Order> QueryByAmountRange(decimal minAmount, decimal maxAmount)
        {
            return orders.Where(o => o.TotalAmount >= minAmount && o.TotalAmount <= maxAmount)
                         .OrderBy(o => o.TotalAmount)
                         .ToList();
        }

        // 排序方法
        public void SortOrders(Comparison<Order> comparison = null)
        {
            if (comparison == null)
                orders.Sort();
            else
                orders.Sort(comparison);
        }

        // 导出订单到文件
        public void Export(string fileName)
        {
            // 实现序列化逻辑
        }

        // 从文件导入订单
        public void Import(string fileName)
        {
            // 实现反序列化逻辑
        }
    }
    class Program
    {
        static OrderService orderService = new OrderService();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nOrder Management System");
                Console.WriteLine("1. Add Order");
                Console.WriteLine("2. Remove Order");
                Console.WriteLine("3. Update Order");
                Console.WriteLine("4. Query Orders");
                Console.WriteLine("5. List All Orders");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1":
                            AddOrder();
                            break;
                        case "2":
                            RemoveOrder();
                            break;
                        case "3":
                            UpdateOrder();
                            break;
                        case "4":
                            QueryOrders();
                            break;
                        case "5":
                            ListAllOrders();
                            break;
                        case "6":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option, please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void AddOrder()
        {
            Console.WriteLine("\nAdd New Order");

            var order = new Order();
            Console.Write("Order ID: ");
            order.OrderId = Console.ReadLine();

            order.Customer = new Customer();
            Console.Write("Customer ID: ");
            order.Customer.CustomerId = Console.ReadLine();
            Console.Write("Customer Name: ");
            order.Customer.Name = Console.ReadLine();
            Console.Write("Customer Contact: ");
            order.Customer.ContactInfo = Console.ReadLine();

            order.OrderDate = DateTime.Now;

            bool addingDetails = true;
            while (addingDetails)
            {
                var detail = new OrderDetails();
                detail.Product = new Product();

                Console.Write("Product ID: ");
                detail.Product.ProductId = Console.ReadLine();
                Console.Write("Product Name: ");
                detail.Product.Name = Console.ReadLine();
                Console.Write("Product Price: ");
                detail.Product.Price = decimal.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                detail.Quantity = int.Parse(Console.ReadLine());

                order.Details.Add(detail);

                Console.Write("Add another product? (y/n): ");
                addingDetails = Console.ReadLine().ToLower() == "y";
            }

            orderService.AddOrder(order);
            Console.WriteLine("Order added successfully.");
        }

        static void RemoveOrder()
        {
            Console.Write("\nEnter Order ID to remove: ");
            string orderId = Console.ReadLine();
            orderService.RemoveOrder(orderId);
            Console.WriteLine("Order removed successfully.");
        }

        static void UpdateOrder()
        {
            Console.Write("\nEnter Order ID to update: ");
            string orderId = Console.ReadLine();

            var existingOrder = orderService.GetAllOrders().FirstOrDefault(o => o.OrderId == orderId);
            if (existingOrder == null)
            {
                Console.WriteLine("Order not found.");
                return;
            }

            Console.WriteLine("Current Order Details:");
            Console.WriteLine(existingOrder);

            var updatedOrder = new Order
            {
                OrderId = existingOrder.OrderId,
                Customer = existingOrder.Customer,
                OrderDate = existingOrder.OrderDate,
                Details = new List<OrderDetails>(existingOrder.Details)
            };

            Console.WriteLine("\nUpdate Customer Info:");
            Console.Write($"Customer Name ({updatedOrder.Customer.Name}): ");
            var nameInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(nameInput))
                updatedOrder.Customer.Name = nameInput;

            Console.Write($"Customer Contact ({updatedOrder.Customer.ContactInfo}): ");
            var contactInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(contactInput))
                updatedOrder.Customer.ContactInfo = contactInput;

            Console.WriteLine("\nUpdate Order Details:");
            for (int i = 0; i < updatedOrder.Details.Count; i++)
            {
                var detail = updatedOrder.Details[i];
                Console.WriteLine($"Detail {i + 1}: {detail}");

                Console.Write($"Update Product Name ({detail.Product.Name})? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.Write("New Product Name: ");
                    detail.Product.Name = Console.ReadLine();
                }

                Console.Write($"Update Quantity ({detail.Quantity})? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.Write("New Quantity: ");
                    detail.Quantity = int.Parse(Console.ReadLine());
                }
            }

            orderService.UpdateOrder(updatedOrder);
            Console.WriteLine("Order updated successfully.");
        }

        static void QueryOrders()
        {
            Console.WriteLine("\nQuery Options:");
            Console.WriteLine("1. By Order ID");
            Console.WriteLine("2. By Customer Name");
            Console.WriteLine("3. By Product Name");
            Console.WriteLine("4. By Amount Range");
            Console.Write("Select query type: ");

            string choice = Console.ReadLine();
            List<Order> results = null;

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Order ID: ");
                    results = orderService.QueryByOrderId(Console.ReadLine());
                    break;
                case "2":
                    Console.Write("Enter Customer Name: ");
                    results = orderService.QueryByCustomer(Console.ReadLine());
                    break;
                case "3":
                    Console.Write("Enter Product Name: ");
                    results = orderService.QueryByProductName(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter Min Amount: ");
                    decimal min = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter Max Amount: ");
                    decimal max = decimal.Parse(Console.ReadLine());
                    results = orderService.QueryByAmountRange(min, max);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            if (results == null || results.Count == 0)
            {
                Console.WriteLine("No orders found.");
                return;
            }

            Console.WriteLine("\nQuery Results:");
            foreach (var order in results)
            {
                Console.WriteLine(order);
                Console.WriteLine("-------------------");
            }
        }

        static void ListAllOrders()
        {
            var orders = orderService.GetAllOrders();
            if (orders.Count == 0)
            {
                Console.WriteLine("No orders available.");
                return;
            }

            Console.WriteLine("\nAll Orders:");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
                Console.WriteLine("-------------------");
            }
        }
    }
}
