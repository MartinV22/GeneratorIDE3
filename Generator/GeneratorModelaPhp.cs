using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public static class GeneratorModelaPhp
    {
        private static List<string> Linije = new List<string>();

        public static void generate()
        {
            Linije.Clear();
            Linije.Add("<?php\n");
            Linije.Add("namespace App;");

            Linije.Add("\nuse DB;");
            Linije.Add(@"use Illuminate\Auth\Authenticatable;");
            Linije.Add(@"use Illuminate\Contracts\Auth\Access\Authorizable as AuthorizableContract;");
            Linije.Add(@"use Illuminate\Contracts\Auth\Access\Authenticatable as AuthenticatableContract;");
            Linije.Add(@"use Illuminate\Database\Eloquent\Model;");
            Linije.Add(@"use Laravel\Lumen\Auth\Authorizable;");
            Linije.Add("\nclass " + Entitet.Name + " extends Model implements AuthenticatableContract, AuthorizableContract\n{\n");
            Linije.Add("\tuse Authenticatable, Authorizable; \n");
            Linije.Add("\tprotected $fillable = [");

            foreach(var atribut in Entitet.AtributList)
            {
                Linije.Add("\t\t'" + atribut.Name + "',");
            }

            Linije.Add("\t];");

            Linije.Add("\n\tprotected $casts = [");

            foreach(var atribut in Entitet.AtributList)
            {
                if(atribut.Type.Name == "boolean")
                {
                    Linije.Add("\t\t'" + atribut.Name + "' => 'boolean',");
                }
                if(atribut.Type.Name == "array")
                {
                    Linije.Add("\t\t'" + atribut.Name + "' => 'array',");
                }
                if(atribut.Type.Name == "date")
                {
                    Linije.Add("\t\t'" + atribut.Name + "' => 'date:Y-m-d',");
                }
                if(atribut.Type.Name == "dateTime")
                {
                    Linije.Add("\t\t'" + atribut.Name + "' => 'datetime:d.m.Y.',");
                }
            }
            Linije.Add("\t];\n ");

            foreach(var atribut in Entitet.AtributList)
            {
                if(atribut.Type.Name == "foreign")
                {
                    char prvoSlovoReference = char.ToUpper(atribut.Reference[0]);
                    string nazivreferenceModel = prvoSlovoReference + atribut.Reference.Substring(1);
                    Linije.Add("\tpublic function " +atribut.Reference + "() \n\t{");
                    Linije.Add("\t\treturn $this->belongsTo(" + nazivreferenceModel+ "::class, '" + atribut.Reference.ToLower() + "', 'id');");
                    Linije.Add("\t}\n");

                }
            }
            Linije.Add("}");

            File.WriteAllLines("ModelPhp.txt", Linije);

        }

    }
}
