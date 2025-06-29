using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecepcjaDlaWeterynarii.Tables;
using RecepcjaDlaWeterynarii.DTO;

namespace RecepcjaDlaWeterynarii
{
    public partial class ucSearchPatient: UserControl
    {
        private readonly DatabaseMethods databaseMethods = new DatabaseMethods();
        private List<PetOwnerInfoForDataGrid> petOwnerInformationList = new List<PetOwnerInfoForDataGrid>();

        public ucSearchPatient()
        {
            InitializeComponent();
        }

        private bool VerifyInputParameters()
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Wymagane jest podanie imienia zwierzęcia do wyszukania informacji!");
                return false;
            }

            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!VerifyInputParameters())
                return;

            Pets pet = databaseMethods.GetPetInfo(tbName.Text);
            Owners owner = databaseMethods.GetOwnerInfo(pet.PetId);
            PetOwnerInfoForDataGrid petOwnerInfo = new PetOwnerInfoForDataGrid(
                pet.Name,
                pet.Type,
                pet.MicrochipNumber,
                owner.Name,
                owner.Address,
                owner.Phone
            );

            petOwnerInformationList.Add(petOwnerInfo);

            dgvPatient.AutoGenerateColumns = true;
            dgvPatient.DataSource = petOwnerInformationList;
        }
    }
}
