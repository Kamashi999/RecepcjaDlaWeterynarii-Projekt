using RecepcjaDlaWeterynarii.Logic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RecepcjaDlaWeterynarii.Logic
{
    /// <summary>
    /// Klasa dziedzicząca po klasie Animal, która dodaje swoją właściwość o nazwie breed (rasa) oraz nadpisuje metodę GetAnimalInfo
    /// </summary>
    class Dog : Animal
    {
        protected string breed;

        public Dog(string name, string species, string sex, int age, int microchipNumber, double weight, string breed) 
            : base(name, species, sex, age, microchipNumber, weight)
        {
            this.breed = breed;
        }

        /// <summary>
        /// Nadpisana metoda GetAnimalInfo, która bierze bazową metodę wirtualną i dodaje do niej wartość zmiennej breed
        /// </summary>
        /// <returns>Zwraca wartość typu string wraz ze złożoną informacją w całość</returns>
        public override string GetAnimalInfo()
        {
            return base.GetAnimalInfo() + $"Rasa: {breed}\n";
        }
    }
}
