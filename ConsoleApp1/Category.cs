using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Category
    {
        public string Name { get; set; }
        public List<Category> Categories = new List<Category>();

        public Category(string Name)
        {
            this.Name = Name;
            Categories.Add(this);
        }

        public List<Category> GetCategories(){
            return Categories;
        }
    }
}
