using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepcjaDlaWeterynarii.Tables
{
    public class Pets
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int MicrochipNumber { get; set; }
    }
}
