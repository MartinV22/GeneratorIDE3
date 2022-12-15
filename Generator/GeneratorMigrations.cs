using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public static class GeneratorMigrations
    {

        public static List<string> Lines = new List<string>();

        public static void generate()
        {
            foreach(var atribut in Entitet.AtributList)
            {
                if (atribut.Type.Name != "foreign")
                {
                    if (atribut.Type.Name != "array")
                    {
                        string input = "$table->" + atribut.Type.Name + "('" + atribut.Name + "')";
                        if (atribut.Nullable)
                        {
                            input += "->nullable()";
                        }
                        if (atribut.HasDefault == true)
                        {
                            input += "->default(" + atribut.DefaultValue + ")";
                        }
                        input += ";";
                        Lines.Add(input);
                    }
                    else
                    {
                        string input = "$table->text('" + atribut.Name + "')";
                        if (atribut.Nullable)
                        {
                            input += "->nullable()";
                        }
                        if (atribut.HasDefault == true)
                        {
                            input += "->default('" + atribut.DefaultValue + "')";
                        }
                        input += ";";
                        Lines.Add(input);
                    }

                }
                else
                {
                    string input = "$table->bigInteger('" + atribut.Name + "')->unsigned()->index();";

                    input += "\n$table->foreign('" + atribut.Name + "')->references('id')->on('" + atribut.Reference.ToLower() + "')";
                    if (atribut.Nullable)
                    {
                        input += "->nullable();";
                    }
                    else
                    {
                        input += ";";
                    }
                    Lines.Add(input);

                }
                }

                Lines.Add("\n$table->timestamps();\n");
                Lines.Add("$table->charset = 'utf8mb4';");
                Lines.Add("$table->collation = 'utf8mb4_croatian_ci';");

            File.WriteAllLines("Migracija.txt", Lines);
        }

    }
}
