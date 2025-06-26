using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace RecepcjaDlaWeterynarii_klasy
{
    abstract class Zwierze
    {
        public string Imie { get; set; }
        public string Gatunek { get; set; }
        public string Plec { get; set; }
        public int Wiek { get; set; }
        public int NumerMikroczipu { get; set; }
        public double Waga { get; set; }

        public Zwierze(string imie, string gatunek, string plec, int wiek, int numerMikroczipu, double waga)
        {
            if (!Regex.IsMatch(imie, @"^[A-Za-z]+$"))
                MessageBox.Show("Imię może zawierać tylko litery.");

            if (!Regex.IsMatch(plec, @"^[A-Za-z]+$"))
                MessageBox.Show("Płeć może zawierać tylko litery.");

            if (wiek < 0 || wiek > 83)
                MessageBox.Show("Wiek musi być w zakresie 0–83.");

            if (waga < 0 || waga > 250)
                MessageBox.Show("Waga musi być w zakresie 0–250 kg.");

            Imie = imie;
            Gatunek = gatunek;
            Plec = plec;
            Wiek = wiek;
            NumerMikroczipu = numerMikroczipu;
            Waga = waga;
        }

    }

    class Pies : Zwierze
    {
        public string Rasa { get; set; }

        public Pies(string imie, string gatunek, string plec, int wiek, int numerMikroczipu, double waga, string rasa)
            : base(imie, gatunek, plec, wiek, numerMikroczipu, waga)
        {
            Rasa = rasa;
        }

        public void Pokaz(Label etykieta)
        {
            etykieta.Text =
                $"Imię: {Imie}\n" +
                $"Gatunek: {Gatunek}\n" +
                $"Płeć: {Plec}\n" +
                $"Wiek: {Wiek} lat\n" +
                $"Numer mikroczipu: {NumerMikroczipu}\n" +
                $"Waga: {Waga} kg\n" +
                $"Rasa: {Rasa}";
        }
    }

    class Waz : Zwierze
    {
        public double Dlugosc { get; set; }

        public Waz(string imie, string gatunek, string plec, int wiek, int numerMikroczipu, double waga, double dlugosc)
            : base(imie, gatunek, plec, wiek, numerMikroczipu, waga)
        {
            if (dlugosc < 10 || dlugosc > 770)
                MessageBox.Show("Długość węża musi być w zakresie 10–770 cm.");

            Dlugosc = dlugosc;
        }

        public void Pokaz(Label etykieta)
        {
            etykieta.Text =
                $"Imię: {Imie}\n" +
                $"Gatunek: {Gatunek}\n" +
                $"Płeć: {Plec}\n" +
                $"Wiek: {Wiek} lat\n" +
                $"Numer mikroczipu: {NumerMikroczipu}\n" +
                $"Waga: {Waga} kg\n" +
                $"Długość: {Dlugosc}";
        }
    }

    class Papuga : Zwierze
    {
        public double DlugoscSkrzydel { get; set; }

        public Papuga(string imie, string gatunek, string plec, int wiek, int numerMikroczipu, double waga, double dlugoscSkrzydel)
            : base(imie, gatunek, plec, wiek, numerMikroczipu, waga)
        {
            if (dlugoscSkrzydel < 5 || dlugoscSkrzydel > 360)
                MessageBox.Show("Rozpiętość skrzydeł papugi musi być w zakresie 5–360 cm.");

            DlugoscSkrzydel = dlugoscSkrzydel;
        }
    }

    class Wlasciciel
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NumerTelefonu { get; set; }
        public string AdresEmail { get; set; }
        public string AdresZamieszkania { get; set; }

        public Wlasciciel(string imie, string nazwisko, string numerTelefonu, string adresZamieszkania, string adresEmail = null)
        {
            if (!Regex.IsMatch(imie, @"^[A-Za-z]+$"))
                MessageBox.Show("Imię właściciela może zawierać tylko litery.");

            if (!Regex.IsMatch(nazwisko, @"^[A-Za-z]+$"))
                MessageBox.Show("Nazwisko właściciela może zawierać tylko litery.");

            if (!Regex.IsMatch(numerTelefonu, @"^\d{9}$"))
                MessageBox.Show("Numer telefonu musi zawierać dokładnie 9 cyfr.");

            Imie = imie;
           
            Nazwisko = nazwisko;
            NumerTelefonu = numerTelefonu;
            AdresEmail = adresEmail;
            AdresZamieszkania = adresZamieszkania;
        }
    }
}
