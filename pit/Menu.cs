using System;
using System.Collections.Generic;

namespace pit
{
    class Menu

    {
        List<Article> menuItems = new List<Article>();


        //constructor
        public Menu()
        {
            Article Americana = new Article(1, "Americana", Category.PIZZA, 6);
            menuItems.Add(Americana);
            Article Bolognese = new Article(2, "Bolognese", Category.PIZZA, 6);
            menuItems.Add(Bolognese);
            Article Francescana = new Article(3, "Francescana", Category.PIZZA, 6);
            menuItems.Add(Francescana);
            Article Hawaii = new Article(4, "Hawaii", Category.PIZZA, 6);
            menuItems.Add(Hawaii);
            Article Pepperoni = new Article(5, "Pepperoni", Category.PIZZA, 6);
            menuItems.Add(Pepperoni);

            Article Pannipizza = new Article(6, "Pannipizza", Category.DOUGH, 8.99);
            menuItems.Add(Pannipizza);
            Article Õhukesepõhjaline = new Article(7, "Õhukesepõhjaline pizza", Category.DOUGH, 6.99);
            menuItems.Add(Õhukesepõhjaline);

            Article Krevetid = new Article(8, "Krevetid", Category.EXTRA, 1.50);
            menuItems.Add(Krevetid);
            Article Soolaseened = new Article(9, "Soolaseened", Category.EXTRA, 0.70);
            menuItems.Add(Soolaseened);
            Article Juust = new Article(10, "Juust", Category.EXTRA, 0.40);
            menuItems.Add(Juust);
            Article Peekon = new Article(11, "Peekon", Category.EXTRA, 0.90);
            menuItems.Add(Peekon);
            Article Paprika = new Article(12, "Paprika", Category.EXTRA, 0.30);
            menuItems.Add(Paprika);
        }

        public List<Article> GetItems(Category category)
        {
            List<Article> pizzaList = new List<Article>();

            foreach (var inStockItem in menuItems)
            {
                if (inStockItem.Category == category.ToString())
                {
                    pizzaList.Add(inStockItem);
                }
            }

            return pizzaList;
        }

        public string GetItemIds(List<Article> itemList)
        {
            string ids = "";

            for (int i = 0; i < itemList.Count; i++)
            {
                Article article = itemList[i];
                ids += article.Id;

                if (i < itemList.Count - 1)
                {
                    ids += ",";
                }
            }

            return ids;
        }

        public void PrintItems(List<Article> items)
        {
            foreach (Article article in items)
            {
                Console.WriteLine($"ID: {article.Id}");
                Console.WriteLine($"Product: {article.Name}");
                Console.WriteLine($"Category: {article.Category}");
                Console.WriteLine($"Price: {article.Price}");
                Console.WriteLine();
            }
        }

        //Get an article object from the list
        public Article GetArticle(int id)
        {
            return menuItems[id - 1];
        }
    }
}