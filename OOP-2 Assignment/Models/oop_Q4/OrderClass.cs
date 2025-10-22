using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OOP Assignment 4: E-Commerce Order System

namespace ConsoleApp12_10_2025.Models
{
    public class OrderClass
    {

        //use array insted of list!
        public OrderClass(string orderNumber, List<ProductClass> products)
        {
            this.orderNumber = orderNumber;
            this.products = products;
        }

        public OrderClass(string orderNumber)
        {
            this.orderNumber = orderNumber;
            this.products = new List<ProductClass>();
        }


        //properties
        public string orderNumber { get; set; }
        public List<ProductClass> products { get; set; } // List<ProductClass> like inheritance of class 


        public void addProduct(ProductClass pd)
        {
            products.Add(pd);
        }

        public double CalculateTotal() {
            double total = 0;
            foreach (ProductClass pd in products) {
                total += pd.CalculateTotal();
            }
            return total;
        }

        public void pdDisplayInfo() {
            Console.WriteLine($"Order number # {orderNumber} ");
            Console.WriteLine("Product");
            foreach (ProductClass pd in products) { 
                pd.pdDisplayInfo();
            }
            Console.WriteLine($"Total cost: {CalculateTotal()}");
        }

    }
}
