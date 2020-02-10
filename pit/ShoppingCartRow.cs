using System;
using System.Collections.Generic;
using System.Text;

namespace pit
{
    class ShoppingCartRow
    {
        Article article;
        int quantity;

        public ShoppingCartRow(Article _article, int _quantity)
        {
            article = _article;
            quantity = _quantity;
        }

        public Article Article
        {
            get { return article; }
        }


        public void PrintItem()
        {
            Console.WriteLine($"ID: {article.Id} \n Name: {article.Name} \n Category: {article.Category} " +
                    $"\n Price: {article.Price}\n Quantity: {quantity} \n " +
                    $"Total: {CalculateItemTotal()}");
        }

        public double CalculateItemTotal()
        {
            return article.Price * quantity;
        }

    }
}

