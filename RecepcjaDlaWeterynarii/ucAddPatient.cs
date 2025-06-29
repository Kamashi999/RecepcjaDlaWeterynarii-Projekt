using RecepcjaDlaWeterynarii.Logic;
using RecepcjaDlaWeterynarii.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcjaDlaWeterynarii
{
    public partial class ucAddPatient : UserControl
    {
        private readonly DatabaseMethods databaseMethods = new DatabaseMethods();
        private string[] species = new string[]
        {
            "Pies",
            "Wąż",
            "Papuga"
        };

        public ucAddPatient()
        {
            InitializeComponent();
            InitializeVariables();
            SetVisibilityOfAdditionalControls();
        }

        private void InitializeVariables()
        {
            cmbSpecies.Items.AddRange(species);
        }

        private void SetVisibilityOfAdditionalControls(bool visible = false)
        {
            lbAdditionalTrait.Visible = visible;
            tbAdditionalTrait.Visible = visible;
        }

        private bool VerifyPetInputParameters()
        {
            if (string.IsNullOrEmpty(tbPetName.Text))
            {
                MessageBox.Show("Proszę podać imię zwierzęcia!");
                return false;
            }

            if (string.IsNullOrEmpty(cmbSpecies.Text))
            {
                MessageBox.Show("Proszę wybrać gatunek zwierzęcia!");
                return false;
            }

            if (string.IsNullOrEmpty(tbSex.Text))
            {
                MessageBox.Show("Proszę podać płeć zwierzęcia!");
                return false;
            }

            if (string.IsNullOrEmpty(tbChipNumber.Text))
            {
                MessageBox.Show("Proszę podać numer chipu zwierzęcia!");
                return false;
            }

            if (string.IsNullOrEmpty(tbAdditionalTrait.Text))
            {
                MessageBox.Show($"Proszę podać dodatkową cechę zwierzęcia!");
                return false;
            }

            return true;
        }

        private bool VerifyOwnerInputParameters()
        {
            if (string.IsNullOrEmpty(tbOwnerName.Text))
            {
                MessageBox.Show("Proszę podać imię właściciela zwierzęcia!");
                return false;
            }

            if (string.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show("Proszę podać nazwisko!");
                return false;
            }

            if (string.IsNullOrEmpty(tbPhoneNumber.Text))
            {
                MessageBox.Show("Proszę podać numer telefonu!");
                return false;
            }

            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Proszę podać adres email!");
                return false;
            }

            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show($"Proszę podać adres zamieszkania!");
                return false;
            }

            return true;
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSpecies.SelectedIndex)
            {
                case 0:
                    lbAdditionalTrait.Text = "Rasa";
                    break;
                case 1:
                    lbAdditionalTrait.Text = "Długość (w cm)";
                    break;
                case 2:
                    lbAdditionalTrait.Text = "Rozpiętość skrzydeł (w cm)";
                    break;
            }

            SetVisibilityOfAdditionalControls(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePet();
            SaveOwner();
            SaveVisit();
        }

        private void SavePet()
        {
            if (!VerifyPetInputParameters())
                return;

            if (!int.TryParse(tbAge.Text, out int age))
            {
                MessageBox.Show($"Proszę podać prawidłowy wiek zwierzęcia!");
                return;
            }

            if (!int.TryParse(tbChipNumber.Text, out int chipNumber))
            {
                MessageBox.Show($"Proszę podać prawidłowy numer chipu zwierzęcia!");
                return;
            }

            if (!double.TryParse(tbAge.Text, out double weight))
            {
                MessageBox.Show($"Proszę podać prawidłową wagę zwierzęcia!");
                return;
            }

            Pets pet = new Pets();

            if (cmbSpecies.SelectedItem == "Pies")
            {
                Dog dog = new Dog(
                    tbPetName.Text,
                    cmbSpecies.Text,
                    tbSex.Text,
                    age,
                    chipNumber,
                    weight,
                    tbAdditionalTrait.Text
                );

                pet = dog.MapAttributesToPets();

                MessageBox.Show($"Informacje końcowe:\n{dog.GetAnimalInfo()}");
            }
            else if (cmbSpecies.SelectedItem == "Wąż")
            {
                int length = Convert.ToInt32(tbAdditionalTrait.Text);
                Snake snake = new Snake(
                    tbPetName.Text,
                    cmbSpecies.Text,
                    tbSex.Text,
                    age,
                    chipNumber,
                    weight,
                    length
                    );

                pet = snake.MapAttributesToPets();

                MessageBox.Show($"Informacje końcowe:\n{snake.GetAnimalInfo()}");
            }
            else if (cmbSpecies.SelectedItem == "Papuga")
            {
                int wingsRange = Convert.ToInt32(tbAdditionalTrait.Text);
                Parrot parrot = new Parrot(
                    tbPetName.Text,
                    cmbSpecies.Text,
                    tbSex.Text,
                    age,
                    chipNumber,
                    weight,
                    wingsRange
                );

                pet = parrot.MapAttributesToPets();

                MessageBox.Show($"Informacje końcowe:\n{parrot.GetAnimalInfo()}");
            }

            databaseMethods.AddPet(pet);
        }

        private void SaveOwner()
        {
            if (!VerifyOwnerInputParameters())
                return;

            Owner owner = new Owner(tbOwnerName.Text, tbLastName.Text, tbPhoneNumber.Text, tbEmail.Text, tbAddress.Text);
            int petId = databaseMethods.GetLatestPetId();

            Owners ownerData = owner.MapAttributesToOwners();
            ownerData.PetId = petId;

            databaseMethods.AddOwner(ownerData);
        }

        private void SaveVisit()
        {
            if (string.IsNullOrEmpty(rtbReason.Text.Trim()))
            {
                MessageBox.Show("Powód wizyty nie może pozostać pusty!");
                return;
            }

            int petId = databaseMethods.GetLatestPetId();
            int ownerId = databaseMethods.GetOwnerId(petId);

            databaseMethods.AddVisit(ownerId, petId, rtbReason.Text);
        }
    }
}