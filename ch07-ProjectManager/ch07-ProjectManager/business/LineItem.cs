using System;
using System.Collections.Generic;
using System.Text;

namespace ch07_ProjectManager.business
{
    class LineItem
    {
        public Product product { get; set; }
        public int quantity { get; set; }
        public double total { get; set; }

        public LineItem()
        {

        }

        public LineItem(Product product, int quantity, double total)
        {
            this.product = product;
            this.quantity = quantity;
            this.total = total;
        }

        public override string ToString()
        {
            return $"LineItem: Product = {product}, Quantity = {quantity}, Total = {total}";
        }
    }
}
