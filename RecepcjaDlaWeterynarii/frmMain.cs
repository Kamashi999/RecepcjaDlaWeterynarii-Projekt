using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepcjaDlaWeterynarii
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyjść?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = result == DialogResult.No;
        }

        private void btnAddPatient_Click(object sender, EventArgs e) //wprowadź pacjenta
        {
            userControl21.Hide();
            userControl11.Show();
        }

        private void btnSearchPatient_Click(object sender, EventArgs e) //Wyszukaj pacjenta
        {
            userControl11.Hide();
            userControl21.Show();
        }
    }
}
