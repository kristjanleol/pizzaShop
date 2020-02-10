using System;
using System.Collections.Generic;
using System.Text;

namespace pit
{
    class ShoppingCart
    {
        List<ShoppingCartRow> shoppingCartRows;
        private double total;

        public ShoppingCart()
        {
            shoppingCartRows = new List<ShoppingCartRow>();
            total = 0;
        }

        public double Total
        {
            get { return total; }
        }

        public void AddToShoppingCart(Article article, int quantity)
        {
            ShoppingCartRow row = new ShoppingCartRow(article, quantity);
            shoppingCartRows.Add(row);
        }

        public void RemoveFromShoppingCart(int id)
        {
            for (int i = 0; i < shoppingCartRows.Count; i++)
            {
                if (shoppingCartRows[i].Article.Id == id)
                {
                    Console.WriteLine($"{shoppingCartRows[i].Article.Name} has been removed.");
                    shoppingCartRows.Remove(shoppingCartRows[i]);
                }
            }
            PrintShoppingCart();
        }
        public void PrintShoppingCart()
        {
            if (shoppingCartRows.Count == 0)
            {
                Console.WriteLine("Shopping Cart is empty");
            }
            else
            {
                foreach (ShoppingCartRow item in shoppingCartRows)
                {
                    item.PrintItem();
                }
            }

        }
        // Calculate shopping cart tool
        public void PrintTotal()
        {
            foreach (ShoppingCartRow item in shoppingCartRows)
            {
                total += item.CalculateItemTotal();
            }
        }

    }
}
