using RecepcjaDlaWeterynarii.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcjaDlaWeterynarii.Logic.Abstract
{
    /// <summary>
    /// Klasa matka odpowiedzialna za przechowywanie bazowych właściwości oraz wirtualnej metody GetAnimalInfo
    /// </summary>
    public abstract class Animal
    {
        protected string name;
        protected string species;
        protected string sex;
        protected int age;
        protected int microchipNumber;
        protected double weight;

        public Animal(string name, string species, string sex, int age, int microchipNumber, double weight)
        {
            if (!Regex.IsMatch(name, @"^[A-Za-z]+$"))
                MessageBox.Show("Imię może zawierać tylko litery.");

            if (!Regex.IsMatch(sex, @"^[A-Za-z]+$"))
                MessageBox.Show("Płeć może zawierać tylko litery.");

            if (age < 0 || age > 83)
                MessageBox.Show("Wiek musi być w zakresie 0–83.");

            if (weight < 0 || weight > 250)
                MessageBox.Show("Waga musi być w zakresie 0–250 kg.");

            this.name = name;
            this.species = species;
            this.sex = sex;
            this.age = age;
            this.microchipNumber = microchipNumber;
            this.weight = weight;
        }

        /// <summary>
        /// Wirtualna metoda odpowiedzialna za zebranie wartości z właściwości klasy Animal
        /// </summary>
        /// <returns>Zwraca wartość typu string wraz ze złożoną informacją w całość</returns>
        public virtual string GetAnimalInfo()
        {
            return $"Imię: {name}\nGatunek: {species}\nPłeć: {sex}\nWiek: {age} lat\nNumer mikroczipu: {microchipNumber}\nWaga: {weight} kg\n";
        }

        /// <summary>
        /// Wirtualna metoda służąca do zmapowania atrybutów dla klasy Pets, aby możliwym było wykonanie inserta niezależnie od gatunku zwierzęcia
        /// </summary>
        /// <returns>Zwraca obiekt klasy typu Pets</returns>
        public virtual Pets MapAttributesToPets()
        {
            return new Pets()
            {
                Name = name,
                Type = species,
                Sex = sex,
                Age = age,
                MicrochipNumber = microchipNumber,
                Weight = weight
            };
        }
    }
}
