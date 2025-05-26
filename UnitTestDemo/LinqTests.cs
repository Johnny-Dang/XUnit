using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace UnitTestDemo
{
    public class LinqTests
    {
        public static Solution sl = new Solution();


        [Fact]
        public void Test()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void When_CustomersHasLengthGreaterThan2_GetTop2CitiesByTotalAmount_ShouldReturnCorrectResult()
        {
            //Arrange
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

            //Act
            var result = Solution.GetTop2CitiesByTotalAmount(customers);

            //Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("HCM City", result.First());
            Assert.Equal("Hanoi", result.Last());

        }

        [Fact]
        public void Test3()
        {
            //Arrange
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


            //Act
            var result = sl.FindCustomerWithMaxTotalAmount(customers);

            //Assert
            Assert.Equal("David", result.Name);
        }

        [Fact]
        public void Test4()
        {
            //Arrange
            List<Customer> customers = new List<Customer>() {
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

            //Act
            var result = sl.GetCustomersWithAtLeast2Orders(customers);

            //Assert
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void Test5()
        {

            //Arrange
            List<Customer> customers = new List<Customer>() {
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

            //Act
            var result = sl.GetCustomersWithAtLeast2Orders(customers);

            //Assert
            Assert.Equal(3, result.Count);

        }

        [Fact]
        public void Test6()
        {

            //Arrange
            List<Customer> customers = new List<Customer>() {
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

            //Act
            var result = sl.GetCustomersWithAtLeast2Orders(customers);

            //Assert
            Assert.Equal(3, result.Count);
        }
    }
}
