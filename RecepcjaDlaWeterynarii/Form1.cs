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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        void Exit()
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyjść?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Exit_click(object sender, EventArgs e)
        {
            Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl11.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
