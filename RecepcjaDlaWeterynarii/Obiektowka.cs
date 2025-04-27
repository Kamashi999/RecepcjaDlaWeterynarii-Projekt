using System;

namespace RecepcjaDlaWeterynarii_klasy
{
    public class animal
    {
        public string Name { set; get; }
        public string Species { set; get; }
        public string Race { set; get; }
        public string Sex { set; get; }

        private int _Age;
        public int Age
        {
            get { return _Age; }
            set
            {
                if (value < 0 || value > 16)
                {
                    throw new ArgumentOutOfRangeException("Wiek musi być w przedziale 0-16 lat.");
                } 
                else
                {
                    _Age = value;
                }
            }
        }

        public int Weight { set; get; }
        public string Issue { set; get; }

        public animal(string name, string species, string race, string sex, int age, int weight, string issue)
        {
            Name = name;
            Species = species;
            Race = race;
            Sex = sex;
            Age = age;
            Weight = weight;
            Issue = issue;
        }

        public string ShowInfo()
        {
            return $"Imię: {Name}\nGatunek: {Species}\nRasa: {Race}\nPłeć: {Sex}\nWiek: {Age}\nWaga: {Weight}\nProblem: {Issue}";
        }
    }
}
