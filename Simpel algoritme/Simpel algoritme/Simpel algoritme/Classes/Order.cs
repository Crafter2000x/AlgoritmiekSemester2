using System;
using System.Collections.Generic;
using System.Text;

namespace Simpel_algoritme.Classes
{
    public class Order
    {
        public List<Product> ProductsInOrder = new List<Product>();

        public double GiveMaximumPrice() 
        {
            if (ProductsInOrder.Count == 0)
            {
                return 0;
            }

            double MaximumPrice = 0;

            foreach (Product product in ProductsInOrder)
            {
                if (MaximumPrice < product.Price)
                {
                    MaximumPrice = product.Price;
                }
            }

            return MaximumPrice;
        }

        public double GiveAveragePrice()
        {
            if (ProductsInOrder.Count == 0)
            {
                return 0;
            }

            double AveragePrice = new double();
            int ProductCounter = new int();

            foreach (Product product in ProductsInOrder)
            {
                AveragePrice += product.Price;
                ProductCounter++;
            }

            AveragePrice = AveragePrice / ProductCounter;

            return Math.Round(AveragePrice,2);
        }

        public List<Product> GetAllProducts(double MinimumPrice)
        {
            List<Product> MinimumPriceProducts = new List<Product>();

            foreach (Product product in ProductsInOrder)
            {
                if (product.Price >= MinimumPrice)
                {
                    MinimumPriceProducts.Add(product);
                }
            }

            return MinimumPriceProducts;
        }

        public void SortProductsByPrice() 
        {
            List<Product> SortedOrderList = new List<Product>();

            foreach (Product product in ProductsInOrder)
            {
                if (SortedOrderList.Count == 0)
                {
                    SortedOrderList.Add(product);
                    continue;
                }

                foreach (Product sortedproduct in SortedOrderList)
                {
                    if (product.Price == sortedproduct.Price)
                    {
                        SortedOrderList.Insert(SortedOrderList.IndexOf(sortedproduct), product);
                        break;
                    }

                    if (product.Price < sortedproduct.Price)
                    {
                        SortedOrderList.Insert(SortedOrderList.IndexOf(sortedproduct), product);
                        break;
                    }

                    if (product.Price > sortedproduct.Price)
                    {
                        if (sortedproduct == SortedOrderList[SortedOrderList.Count - 1])
                        {
                            SortedOrderList.Add(product);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
            }

            ProductsInOrder = SortedOrderList;
        }
    }
}
