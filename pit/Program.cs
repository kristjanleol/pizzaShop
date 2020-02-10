using System;
using System.Collections.Generic;
using System.Linq;

namespace pit
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                
                Menu menu = new Menu();          
                ShoppingCart shoppingCart = new ShoppingCart();


                OrderItem(Category.PIZZA, menu, shoppingCart);

                while (true)
                {
                    Console.WriteLine("Add/Add extra/Choose dough/Remove/Confirm");
                    string userInput = Console.ReadLine().ToLower();
                    if (userInput == "add")
                    {
                        OrderItem(Category.PIZZA, menu, shoppingCart);
                    }
                    else if (userInput == "add extra")
                    {
                        OrderItem(Category.EXTRA, menu, shoppingCart);
                    }
                    else if (userInput == "choose dough")
                    {
                        OrderItem(Category.DOUGH, menu, shoppingCart);
                    }
                    else if (userInput == "remove")
                    {
                        Console.WriteLine("Enter the id of the pizza you'd like to remove: ");
                        int itemIdToRemove = int.Parse(Console.ReadLine());
                        shoppingCart.RemoveFromShoppingCart(itemIdToRemove);
                    }
                    else if (userInput == "confirm")
                    {
                        shoppingCart.PrintTotal();
                        Console.WriteLine($"Shopping cart total:{shoppingCart.Total}");
                        break;
                    }
                }
            }
        }
        private static void OrderItem(Category category, Menu menu, ShoppingCart shoppingCart)
        {
            //get items by category
            List<Article> items = menu.GetItems(category);

            //print out items
            menu.PrintItems(items);

            //concat item IDs into one string
            string itemIds = menu.GetItemIds(items);

            //Get user input
            Console.WriteLine("Enter the id of the item you would like to order: " + itemIds +": ");
            int productID = int.Parse(Console.ReadLine());
            if (new List<string>(itemIds.Split(",")).Contains(productID.ToString()))
            {

                Console.WriteLine("Enter the number of item to add to the shopping cart: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.Clear();

                //Get article from menu
                Article articleToAdd = menu.GetArticle(productID);

                shoppingCart.AddToShoppingCart(articleToAdd, quantity);

                shoppingCart.PrintShoppingCart();
            }
            else
            {
                Console.WriteLine("No such item found in this category!");

            }
        }
    }
}
