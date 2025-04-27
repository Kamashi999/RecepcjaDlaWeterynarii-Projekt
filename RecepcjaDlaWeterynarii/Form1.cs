using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecepcjaDlaWeterynarii_klasy;

namespace RecepcjaDlaWeterynarii
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.Show();
            userControl31.Hide();
        }

        void Exit()
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyjść?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        void InsertInfo()
        {
            userControl11.Show();
            userControl31.Hide();
        }

        void SearchInfo()
        {
            userControl11.Hide();
            userControl31.Show();
        }

        private void FirstButton(object sender, EventArgs e)
        {
            InsertInfo();
        }

        private void SecondButton(object sender, EventArgs e)
        {
            SearchInfo();
        }

        private void Exit_click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}
