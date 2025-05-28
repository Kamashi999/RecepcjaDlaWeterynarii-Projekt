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
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
