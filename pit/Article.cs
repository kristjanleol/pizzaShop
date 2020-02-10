﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pit
{
    enum Category
    {
        PIZZA,
        EXTRA,
        DOUGH
    }
    class Article
    {
        int id;
        string name;
        Category category;
        double price;
        public Article(int _id, string _name, Category _category, double _price)
        {
            id = _id;
            name = _name;
            category = _category;
            price = _price;
        }

        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }

        public string Category
        {
            get { return category.ToString(); }
        }

        public double Price
        {
            get { return price; }
        }

    }
}

