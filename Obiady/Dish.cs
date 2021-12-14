using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiady
{
    public class Dish
    {
        public string name;
        public int count;
        public int priority;
        public List<string> ingredients;
        public string category;
        public string description;

        public Dish() { }

        public Dish(string name, int count, int priority, string category, string description)
        {
            this.name = name;
            this.count = count;
            this.priority = priority;
            this.category = category;
            this.ingredients = new List<string>();
            this.description = description;
        }
    }
}
