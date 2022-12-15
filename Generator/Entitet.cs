using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public static  class Entitet
    {
        public static string Name{ get; set; }
        public static List<Atribut> AtributList{ get; set; }

        public static bool clear()
        {
            Entitet.AtributList = new List<Atribut>();
            return true;
        }
    }
}
