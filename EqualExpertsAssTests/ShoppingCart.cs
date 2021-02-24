using System;
using System.Collections.Generic;

namespace EqualExpertsAssTests
{
    public class ShoppingCart
    {
        Double TotalPrice { get; set; }
        Double Vat { get; set; }
        List<Product> Cart { get; set; }
        public ShoppingCart(double vat)
        {
            TotalPrice = 0.0;
            Cart = new List<Product>();
            Vat = vat;
        }
        public void AddProduct(Product item)
        {
            Cart.Add(item);
            TotalPrice += item.unitPrice;
        }

        public List<Product> GetProducts()
        {
            return Cart;
        }

        public Decimal GetTotalPrice()
        {
            var total = new Decimal(TotalPrice);
            return total + GetVat();
        }

        public decimal GetVat()
        {
            decimal value = new Decimal(TotalPrice * (Vat / 100));
            return Math.Round(value, 2);
        }
    }
}
