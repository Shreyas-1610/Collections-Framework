using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaInClass
{
    public class Problems
    {
        public List<String> count = new List<String>() { 
            "shreyas",
            "sad",
            "sock",
            "seed",
            "seek",
            "thesis"
        };

        public List<int> ints = new List<int>() {12,13,14,22,1,10,88,44};

        public List<string> strings = new List<string>() {"Apple","Ashes","Alex","Shreyas","Aqua" };
    }
    public class People
    {
        public int Id { get; set; }
        public int Age { get; set; }

        public static List<People> GetPeoples()
        {
            List<People> peoples = new List<People>{
            new People{Id = 1, Age = 18},
            new People{Id = 2, Age = 18},
            new People{Id = 3, Age = 20},
            new People{Id = 4, Age = 20},
            };
            return peoples;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public static List<Product> GetProducts() 
        {
            List<Product> products = new List<Product>()
            {
                new Product{Name = "Apple", Price = 110},
                new Product{Name = "Orange", Price = 150},
                new Product{Name = "Mango", Price = 200},
                new Product{Name = "Pear", Price = 50},
                new Product{Name = "Pineapple", Price = 80},

            };
            return products;
        }
    }
}
