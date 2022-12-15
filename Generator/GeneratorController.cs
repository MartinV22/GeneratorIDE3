using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public static class GeneratorController
    {
        private static List<string> Linije = new List<string>();

        public static void generate()
        {
            Linije.Clear();
            Linije.Add("<?php\n");
            Linije.Add(@"namespace App\Http\Controllers");
            Linije.Add( @"use App\" + Entitet.Name + ";");
            Linije.Add("use DB;");
            Linije.Add(@"use Illuminate\Http\Request;" );
            Linije.Add(@"use PhpOffice\PhpSpreadsheet\Spreadsheet;" );
            Linije.Add(@"use Laravel\Lumen\Routing\Controller as BaseController;" + "\n");
            Linije.Add("class " + Entitet.Name + "Controller extends BaseController\n{");
            Linije.Add("\tprivate $request;\n");
            Linije.Add("\tpublic function __construct(Request $request)\n\t{\n");
            Linije.Add("\t\t$this->request = $request;\n\t}\n");

            getAll();



            Linije.Add("}");

            File.WriteAllLines("Controller.txt", Linije);
        }



        private static void getAll()
        {
            string varijabla = char.ToLower(Entitet.Name[0]).ToString() + Entitet.Name.Substring(1) + "s";

            Linije.Add("\tpublic function getAll()\n\t{\n");
            Linije.Add("\t\t$" + varijabla + " = " + Entitet.Name + "::get();");
            Linije.Add("\t\tif ($" + varijabla + ") {\n");
            Linije.Add("\t\t\treturn response()->json($" + varijabla + ",200);");
            Linije.Add("\t\t}\n\t\treturn response()->json([],200);\n\t}");

        }
    }
}
