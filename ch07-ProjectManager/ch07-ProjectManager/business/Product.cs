using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ch07_ProjectManager.business
{
    class Product
    {
        public String code { get; set; }
        public String description { get; set; }
        public double price { get; set; }

        public Product()
        {

        }
        public Product(string code, string description, double price)
        {
            this.code = code;
            this.description = description;
            this.price = price;
        }

        //public override string ToString()
        //{
        //    return "Product: Code = " + code + ", Description = " + description + ", Price = " + price;
        //}

        // using string interpolation
        public override string ToString()
        {
            return $"Product: Code = {code}, Description = {description}, Price = {price}";
        }
    }
}
