using RecepcjaDlaWeterynarii.Logic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcjaDlaWeterynarii.Logic
{
    /// <summary>
    /// Klasa dziedzicząca po klasie Animal, która dodaje swoją właściwość o nazwie length (długość) oraz nadpisuje metodę GetAnimalInfo
    /// </summary>
    class Snake : Animal
    {
        protected double length;

        public Snake(string name, string species, string sex, int age, int microchipNumber, double weight, double length) 
            : base(name, species, sex, age, microchipNumber, weight)
        {
            if (length < 10 || length > 770)
            {
                MessageBox.Show("Długość węża musi być w zakresie 10–770 cm.");
                return;
            }

            this.length = length;
        }

        /// <summary>
        /// Nadpisana metoda GetAnimalInfo, która bierze bazową metodę wirtualną i dodaje do niej wartość zmiennej length
        /// </summary>
        /// <returns>Zwraca wartość typu string wraz ze złożoną informacją w całość</returns>
        public override string GetAnimalInfo()
        {
            return base.GetAnimalInfo() + $"Długość: {length} cm\n";
        }
    }
}
