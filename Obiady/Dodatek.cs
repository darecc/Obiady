using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiady
{
    public class Dodatek
    {

        public string nazwa;
        public int ileRazy;
        public int priorytet;
        public Dodatek() { }
        public Dodatek(string nazwa, int ileRazy, int priorytet)
        {
            this.nazwa = nazwa;
            this.ileRazy = ileRazy;
            this.priorytet = priorytet;
        }
    }
}
