using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Composição.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }
        
        public double subTotal()
        {
            return  Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + ", Subtotal: $"
                + subTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
