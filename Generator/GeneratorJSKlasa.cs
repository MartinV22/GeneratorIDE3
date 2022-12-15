using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public static class GeneratorJSKlasa
    {

        private static List<string> JSKlasaList = new List<string>();

        public static void generate()
        {
            JSKlasaList.Clear();
            JSKlasaList.Add("/*eslint-disable*/");
            string naziv = Entitet.Name;
            JSKlasaList.Add("class " + naziv + "{");
            JSKlasaList.Add("\tid = null;");

            foreach(var atribut  in Entitet.AtributList)
            {
                if (atribut.Type.Name == "string" || atribut.Type.Name == "text" || atribut.Type.Name == "array" )
                {
                    JSKlasaList.Add("\t" + atribut.Name + " = '';");
                }
                else if (atribut.Type.Name == "integer")
                {
                    JSKlasaList.Add("\t" + atribut.Name + " = 0;");
                }
                else if (atribut.Type.Name == "foreign" || atribut.Type.Name == "datetime" || atribut.Type.Name == "datetime")
                {
                    JSKlasaList.Add("\t" + atribut.Name + " = null;");
                }
                else  if(atribut.Type.Name == "boolean")
                {
                    JSKlasaList.Add("\t" + atribut.Name + " = false;");
                }
            }
            
            JSKlasaList.Add("\n\tconstructor(data, validation = false) {");
            JSKlasaList.Add("\t\tfor(const [key, value] of Object.entries(data)) {");
            JSKlasaList.Add("\t\t\tthis[key] = value;\n\t\t}");
            JSKlasaList.Add("\t\tif (validation) {");
            JSKlasaList.Add("\t\t\tfor(const [key, value] of Object.entries(this)) {");
            JSKlasaList.Add("\t\t\t\tthis[key] = '';\n\t\t\t}");
            JSKlasaList.Add("\t\t}");
            JSKlasaList.Add("\t}");
            JSKlasaList.Add("}");
            JSKlasaList.Add("\nexport default " + Entitet.Name + ";");

            File.WriteAllLines("KlasaJS.txt", JSKlasaList);
        }
    }
}
