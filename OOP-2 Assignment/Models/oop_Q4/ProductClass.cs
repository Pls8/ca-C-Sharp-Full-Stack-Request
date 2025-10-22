using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OOP Assignment 4: E-Commerce Order System

namespace ConsoleApp12_10_2025.Models
{
    public class ProductClass
    {
      

        public ProductClass(string productName, int pdQuantity, double pdPrice)
        {
            this.productName = productName;
            this.pdQuantity = pdQuantity;
            this.pdPrice = pdPrice;
            //this.orderNumber = orderNumber;
        }


        public ProductClass(string productName, double pdPrice)
        {
            this.productName = productName;
            this.pdQuantity = 0;
            this.pdPrice = pdPrice;
            //this.orderNumber = "";
            //   ^ this has error: Either write string? orderNumber or add empty string ""
        }



        //CalculateTotal No parameter 
        public double CalculateTotal() {
            return (double)this.pdPrice * this.pdQuantity;
        }

        public double CalculateTotal(int quantity, double price)
        {
            return (double)this.pdPrice * this.pdQuantity;
        }




        public string productName { get; set; }
        public int pdQuantity { get; set; }
        public double pdPrice { get; set; }
        //public string orderNumber { get; set; }


        public void pdDisplayInfo() {
            Console.WriteLine($"Name {productName} | Quantity {pdQuantity} | Price {pdPrice}");
        }

    }
}
