using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Atribut
    {
        public string Name { get; set; }
        public VrstaAtributa Type { get; set; }
        public string Reference { get; set; }
        public bool Nullable{ get; set; }
        public bool HasDefault { get; set; }
        public string DefaultValue { get; set; }

        public Atribut(string name,VrstaAtributa  type, string reference, bool nullable, bool hasDefault ,string defaultValue)
        {
            this.Name = name;
            this.Type = type;
            if(reference != null)
            {
                this.Reference = reference;
            }
            else
            {
                Reference = null;
            }
            this.Nullable = nullable;
            this.DefaultValue = defaultValue;
            this.HasDefault = hasDefault;
        }
        public Atribut()
        {

        }
    }
}
