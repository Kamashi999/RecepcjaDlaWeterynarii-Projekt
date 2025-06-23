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
using RecepcjaDlaWeterynarii_klasy;

namespace RecepcjaDlaWeterynarii
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Pies");
            comboBox1.Items.Add("Papuga");
            comboBox1.Items.Add("Wąż");
            PiesHide();
            PapugaHide();
            WazHide();
            dlugoscCm.Hide();
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
            dlugoscCm.Show();
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
            dlugoscCm.Show();
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
                dlugoscCm.Hide();
            }
            else if (comboBox1.Text == "Papuga")
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
                dlugoscCm.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wiek = Convert.ToInt32(textBox8.Text);
            int mikroczip = Convert.ToInt32(textBox7.Text);
            double waga = Convert.ToDouble(textBox6.Text);



            if (comboBox1.SelectedItem == "Pies")
            {
                Pies pies = new Pies(
                    textBox1.Text,
                    comboBox1.Text,
                    textBox3.Text,
                    wiek,
                    mikroczip,
                    waga,
                    piesRasaText.Text
                );

                MessageBox.Show("test");
            }
            else if (comboBox1.SelectedItem == "Wąż")
            {
                int dlugoscCm = Convert.ToInt32(wazDlugoscText.Text);
                Waz waz = new Waz(
                    textBox1.Text,
                    comboBox1.Text,
                    textBox3.Text,
                    wiek,
                    mikroczip,
                    waga,
                    dlugoscCm
                    );
                waz.Pokaz(label4);
            }
            else if (comboBox1.SelectedItem == "Papuga")
            {
                int dlugoscSkrzydlaCm = Convert.ToInt32(papugaSkrzydlaText.Text);
                Papuga papuga = new Papuga(
                textBox1.Text,
                comboBox1.Text,
                textBox3.Text,
                wiek,
                mikroczip,
                waga,
                dlugoscSkrzydlaCm
            );
            }
        }
    }
}

