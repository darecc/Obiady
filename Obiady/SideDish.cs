using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiady
{
    public class SideDish
    {

        public string name;
        public int count;
        public int priority;
        public List<string> ingredients;
        public SideDish() { }
        public SideDish(string name, int count, int priority)
        {
            this.name = name;
            this.count = count;
            this.priority = priority;
            ingredients = new List<string>();
        }
    }
}
