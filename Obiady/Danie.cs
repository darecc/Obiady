using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiady
{
    public class Danie
    {
        public string nazwa;
        public int ileRazy;
        public int priorytet;
        public string kategoria;

        public Danie() { }

        public Danie(string nazwa, int ileRazy, int priorytet, string kategoria)
        {
            this.nazwa = nazwa;
            this.ileRazy = ileRazy;
            this.priorytet = priorytet;
            this.kategoria = kategoria;
        }

    }
}
