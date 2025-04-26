using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepcjaDlaWeterynarii_klasy
{
    public class animal
    {
        public string Name { get; set; }
        public string Specs { get; set; }

        public animal(string name, string specs)
        {
            Name = name;
            Specs = specs;
        }

        public string ShowInfo()
        {
            return $"Imię: {Name}\nSpecyfikacja: {Specs}";
        }
    }
}
