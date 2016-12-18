using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gündesaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gunlukSaat = Convert.ToInt32(textBox1.Text);
            int gun = 10000 / gunlukSaat;
            int ay = gun / 30;
            int yil = ay / 12;

            MessageBox.Show("Yıl : " + yil + "\nAy : " + ay + "\nGun : " + gun); 
        }
    }
}
