using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simpel_algoritme.Classes;

namespace Simpel_algoritme.UnitTests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void GiveMaximumPrice_NoProducts_Returns0()
        {
            // Arrange
            var order = new Order();

            // Act
            var result = order.GiveMaximumPrice();

            // Assert
            bool check;
            if (result == 0)
            {
                check = true;
            }
            else
            {
                check = false;

            }

            Assert.IsTrue(check);
        }

        [TestMethod]
        public void GiveMaximumPrice_5Products_Returns10()
        {
            // Arrange
            var order = new Order();
            order.ProductsInOrder.Add(new Product { Name = "1euro", Price = 1 });
            order.ProductsInOrder.Add(new Product { Name = "2euro", Price = 2 });
            order.ProductsInOrder.Add(new Product { Name = "4euro", Price = 4 });
            order.ProductsInOrder.Add(new Product { Name = "6euro", Price = 6 });
            order.ProductsInOrder.Add(new Product { Name = "10euro", Price = 10 });

            // Act
            var result = order.GiveMaximumPrice();

            // Assert
            bool check;
            if (result == 10)
            {
                check = true;
            }
            else
            {
                check = false;

            }

            Assert.IsTrue(check);
        }

        [TestMethod]
        public void GiveAveragePrice_0Products_Returns0()
        {
            // Arrange
            var order = new Order();

            // Act
            var result = order.GiveAveragePrice();

            // Assert
            bool check;
            if (result == 0)
            {
                check = true;
            }
            else
            {
                check = false;

            }

            Assert.IsTrue(check);
        }

        [TestMethod]
        public void GiveAveragePrice_5Products_Returns4_6()
        {
            // Arrange
            var order = new Order();
            order.ProductsInOrder.Add(new Product { Name = "1euro", Price = 1 });
            order.ProductsInOrder.Add(new Product { Name = "2euro", Price = 2 });
            order.ProductsInOrder.Add(new Product { Name = "4euro", Price = 4 });
            order.ProductsInOrder.Add(new Product { Name = "6euro", Price = 6 });
            order.ProductsInOrder.Add(new Product { Name = "10euro", Price = 10 });

            // Act
            var result = order.GiveAveragePrice();

            // Assert
            bool check;
            if (result == 4.6)
            {
                check = true;
            }
            else
            {
                check = false;

            }

            Assert.IsTrue(check);
        }

        [TestMethod]
        public void GetAllProducts_5Products_ReturnsListCount3()
        {
            // Arrange
            var order = new Order();
            order.ProductsInOrder.Add(new Product { Name = "1euro", Price = 1 });
            order.ProductsInOrder.Add(new Product { Name = "2euro", Price = 2 });
            order.ProductsInOrder.Add(new Product { Name = "4euro", Price = 4 });
            order.ProductsInOrder.Add(new Product { Name = "6euro", Price = 6 });
            order.ProductsInOrder.Add(new Product { Name = "10euro", Price = 10 });

            // Act
            var result = order.GetAllProducts(3);

           
            bool check;
            if (result.Count == 3)
            {
                check = true;
            }
            else
            {
                check = false;

            }

            Assert.IsTrue(check);
        }

        [TestMethod]
        public void SortProductsByPrice_10Products_ReturnsSortedListDesc()
        {

            // Arrange
            var order = new Order();
            order.ProductsInOrder.Add(new Product { Name = "12,50euro", Price = 12.5 });
            order.ProductsInOrder.Add(new Product { Name = "14,50euro", Price = 14.5 });
            order.ProductsInOrder.Add(new Product { Name = "15euro", Price = 15 });
            order.ProductsInOrder.Add(new Product { Name = "20euro", Price = 20 });
            order.ProductsInOrder.Add(new Product { Name = "0.50euro", Price = 0.5 });

            order.ProductsInOrder.Add(new Product { Name = "1euro", Price = 1 });
            order.ProductsInOrder.Add(new Product { Name = "2euro", Price = 2 });
            order.ProductsInOrder.Add(new Product { Name = "4euro", Price = 4 });
            order.ProductsInOrder.Add(new Product { Name = "6euro", Price = 6 });
            order.ProductsInOrder.Add(new Product { Name = "10euro", Price = 10 });

            var compare = order.ProductsInOrder;

            // Act
            order.SortProductsByPrice();
            var result = order.ProductsInOrder;
            compare.Sort((x, y) => x.Price.CompareTo(y.Price));

            // Assert
            bool check = true;
            int counter = 0;
            foreach (var item in result)
            {
                if (item.Price != compare[counter].Price)
                {
                    check = false;
                }
                counter++;
            }

            Assert.IsTrue(check);

        }
    }
}
