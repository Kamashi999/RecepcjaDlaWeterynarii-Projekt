using RecepcjaDlaWeterynarii_klasy;
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
    public partial class UserControl1 : UserControl
    {
        Dictionary<int, animal> animals = new Dictionary<int, animal>();
        public UserControl1()
        {
            InitializeComponent();
        }

        void SaveInfos()
        {
            int newId = animals.Count + 1;
            animal pies1 = new animal(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, int.Parse(textBox5.Text), int.Parse(textBox6.Text), richTextBox1.Text);
            animals.Add(newId, pies1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveInfos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(animals[2].ShowInfo());
        }
    }
}
