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
using MaterialSkin;
using MaterialSkin.Controls;

namespace RecepcjaDlaWeterynarii
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Recepcja Weterynarii - Panel Główny";
            userControl11.Hide();
            userControl21.Hide();


            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE);
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
             materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.LIGHT
        ? MaterialSkinManager.Themes.DARK
        : MaterialSkinManager.Themes.LIGHT;
        }
    }
}
// test

// test2


// test3
