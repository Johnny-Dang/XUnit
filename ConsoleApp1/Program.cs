using ConsoleApp1;

public class Solution
{
    static void Main()
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer
            {
                Id = 1, Name = "Alice", City = "Hanoi",
                Orders = new List<Order>
                {
                    new Order { Id = 1, CustomerId = 1, OrderDate = DateTime.Now.AddMonths(-1), TotalAmount = 1000 },
                    new Order { Id = 2, CustomerId = 1, OrderDate = DateTime.Now.AddMonths(-2), TotalAmount = 1500 }
                }
            },
            new Customer
            {
                Id = 2, Name = "Bob", City = "HCM City",
                Orders = new List<Order>
                {
                    new Order { Id = 3, CustomerId = 2, OrderDate = DateTime.Now.AddMonths(-3), TotalAmount = 2000 }
                }
            },
            new Customer
            {
                Id = 3, Name = "Charlie", City = "Danang",
                Orders = new List<Order>
                {
                    new Order { Id = 4, CustomerId = 3, OrderDate = DateTime.Now.AddMonths(-4), TotalAmount = 500 },
                    new Order { Id = 5, CustomerId = 3, OrderDate = DateTime.Now.AddMonths(-1), TotalAmount = 1200 }
                }
            },
            new Customer
            {
                Id = 4, Name = "David", City = "Hanoi",
                Orders = new List<Order>
                {
                    new Order { Id = 6, CustomerId = 4, OrderDate = DateTime.Now.AddMonths(-1), TotalAmount = 900 }
                }
            },
            new Customer
            {
                Id = 5, Name = "Emma", City = "HCM City",
                Orders = new List<Order>
                {
                    new Order { Id = 7, CustomerId = 5, OrderDate = DateTime.Now.AddMonths(-5), TotalAmount = 3000 },
                    new Order { Id = 8, CustomerId = 5, OrderDate = DateTime.Now.AddMonths(-2), TotalAmount = 3500 }
                }
            }
        };

        var result = GetTop2CitiesByTotalAmount(customers);
    }

    //Lấy top 2 thành phố có tổng doanh thu đơn hàng cao nhất

    public static List<string> GetTop2CitiesByTotalAmount(List<Customer> customers)
    {
        Dictionary<string, double> cities = new Dictionary<string, double>();

        foreach (Customer customer in customers)
        {
            if (cities.ContainsKey(customer.City))
            {
                cities[customer.City] += customer.Orders.Sum(o => o.TotalAmount);
            }
            else
            {
                cities.Add(customer.City, customer.Orders.Sum(o => o.TotalAmount));
            }
        }
        return cities.OrderByDescending(city => city.Value).Take(2).Select(city => city.Key).ToList();
    }



    //  Tìm khách hàng có tổng giá trị đơn hàng cao nhất.q
    public Customer FindCustomerWithMaxTotalAmount(List<Customer> customers)
    {
        return customers.OrderByDescending(x => x.Orders.Sum(x => x.TotalAmount)).First();
    }

    //  Lấy danh sách khách hàng có ít nhất 2 đơn hàng.
    public List<Customer> GetCustomersWithAtLeast2Orders(List<Customer> customers)
    {
        return customers.Where(c => c.Orders.Count >= 2).ToList();
    }

    //  Lấy danh sách đơn hàng trong 3 tháng gần nhất (tính từ thời điểm hiện tại).
    public List<Order> GetOrdersInLast3Months(List<Customer> customers)
    {
        DateTime threeMonthsAgo = DateTime.Now.AddMonths(-3);
        return customers.SelectMany(c => c.Orders).Where(o => o.OrderDate >= threeMonthsAgo).ToList();
    }

    //  Lấy top 2 thành phố có tổng doanh thu đơn hàng cao nhất.
    public List<string> GetTop3CitiesByTotalAmount(List<Customer> customers)
    {
        return customers
            .GroupBy(c => c.City)
            .Select(g => new { City = g.Key, TotalAmount = g.Sum(c => c.Orders.Sum(o => o.TotalAmount)) })
            .OrderByDescending(g => g.TotalAmount)
            .Take(2)
            .Select(g => g.City)
            .ToList();
    }

    //  Tìm đơn hàng có giá trị lớn thứ hai.
    public Order FindSecondMaxTotalAmountOrder(List<Customer> customers)
    {
        return customers
            .SelectMany(c => c.Orders)                     // Gộp tất cả đơn hàng từ các khách hàng
            .OrderByDescending(o => o.TotalAmount)         // Sắp xếp giảm dần theo giá trị đơn hàng
            .Skip(1)                                       // Bỏ qua đơn hàng lớn nhất
            .FirstOrDefault();                             // Lấy đơn hàng tiếp theo (lớn thứ hai)
    }
}