using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiady
{
    public class Ingredient
    {
        public string name;
        public string category;
        public Ingredient()
        {

        }
        public Ingredient(string name, string category)
        {
            this.category = category;
            this.name = name;
        }
    }
}
