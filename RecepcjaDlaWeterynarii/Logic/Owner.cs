using RecepcjaDlaWeterynarii.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcjaDlaWeterynarii.Logic
{
    class Owner
    {
        private string name;
        private string lastName;
        private string phoneNumber;
        private string email;
        private string address;

        public Owner(string name, string lastName, string phoneNumber, string email, string address)
        {
            if (!Regex.IsMatch(name, @"^[A-Za-z]+$"))
            {
                MessageBox.Show("Imię właściciela może zawierać tylko litery.");
                return;
            }

            if (!Regex.IsMatch(lastName, @"^[A-Za-z]+$"))
            {
                MessageBox.Show("Nazwisko właściciela może zawierać tylko litery.");
                return;
            }

            if (!Regex.IsMatch(phoneNumber, @"^\d{9}$"))
            {
                MessageBox.Show("Numer telefonu musi zawierać dokładnie 9 cyfr.");
                return;
            }

            this.name = name;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
        }

        public Owners MapAttributesToOwners()
        {
            return new Owners()
            {
                Name = name,
                LastName = lastName,
                Phone = phoneNumber,
                Email = email,
                Address = address
            };
        }
    }
}
