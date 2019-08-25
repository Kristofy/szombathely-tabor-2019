using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbázisok
{
    class Tanulo
    {
        public int ID { get; set; }
        public string nev { get; set; }
        public int kor { get; set; }
        public string nem { get; set; }
        public string haz { get; set; }
        public string tulajdonsagok { get; set; }
        public Tanulo() { }

        public Tanulo(string nev, int kor, string nem, string haz, string tulajdonsagok)
        {
            this.nev = nev;
            this.kor = kor;
            this.nem = nem;
            this.haz = haz;
            this.tulajdonsagok = tulajdonsagok;
        }

        public override string ToString()
        {
            return nev + ";" + kor + ";" + nem + ";" + haz + ";" + tulajdonsagok;
        }

    }
}
