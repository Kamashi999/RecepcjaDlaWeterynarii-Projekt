using RecepcjaDlaWeterynarii.Logic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcjaDlaWeterynarii.Logic
{
    /// <summary>
    /// Klasa dziedzicząca po klasie Animal, która dodaje swoją właściwość o nazwie wingsRange (rozpiętość skrzydeł) oraz nadpisuje metodę GetAnimalInfo
    /// </summary>
    class Parrot : Animal
    {
        protected double wingsRange;

        public Parrot(string name, string species, string sex, int age, int microchipNumber, double weight, double wingsRange) 
            : base(name, species, sex, age, microchipNumber, weight)
        {
            if (wingsRange < 5 || wingsRange > 360)
            {
                MessageBox.Show("Rozpiętość skrzydeł papugi musi być w zakresie 5–360 cm.");
                return;
            }

            this.wingsRange = wingsRange;
        }

        /// <summary>
        /// Nadpisana metoda GetAnimalInfo, która bierze bazową metodę wirtualną i dodaje do niej wartość zmiennej wingsRange
        /// </summary>
        /// <returns>Zwraca wartość typu string wraz ze złożoną informacją w całość</returns>
        public override string GetAnimalInfo()
        {
            return base.GetAnimalInfo() + $"Długość skrzydeł: {wingsRange} cm\n";
        }
    }
}
