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
    public partial class UserControl1 : UserControl
    {
        Dictionary<int, animal> animals = new Dictionary<int, animal>();

        int i = 1;
        public UserControl1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Pies");
            comboBox1.Items.Add("Papuga");
            comboBox1.Items.Add("Wąż");
            PiesHide();
            PapugaHide();
            WazHide();
        }
        void PiesShow()
        {
            piesRasa.Show();
            piesRasaText.Show();
        }

        void PapugaShow()
        {
            papugaSkrzydla.Show();
            papugaSkrzydlaText.Show();
        }

        void PiesHide()
        {
            piesRasa.Hide();
            piesRasaText.Hide();
        }

        void PapugaHide()
        {
            papugaSkrzydla.Hide();
            papugaSkrzydlaText.Hide();
        }

        void WazShow()
        {
            wazDlugosc.Show();
            wazDlugoscText.Show();
        }

        void WazHide()
        {
            wazDlugosc.Hide();
            wazDlugoscText.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Pies")
            {
                PiesShow();
                PapugaHide();
                WazHide();
            } else if (comboBox1.Text == "Papuga")
            {
                PapugaShow();
                PiesHide();
                WazHide();
            }
            else if (comboBox1.Text == "Wąż")
            {
                WazShow();
                PiesHide();
                PapugaHide();
            }
            else
            {
                PiesHide();
                PapugaHide();
                WazHide();
            }
        }
    }
}
