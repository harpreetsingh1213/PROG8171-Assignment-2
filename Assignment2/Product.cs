using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment2
{
    internal class Product
    {
        public int productID;
        public string productName;
        public double price;
        public double stock;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Product(int productID, string productName, double price, int stock)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price;
            this.stock = stock;
        }

        public void IncreaseStock(int amount)
        {
            Stock += amount;
        }

        public void DecreaseStock(int amount)
        {
            Stock -= amount;
        }
    }
}
