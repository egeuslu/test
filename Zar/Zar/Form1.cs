using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AtBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int tursayisi = 1;
          
        

            int sayi1;
            int sayi2;
            Random random = new Random();
            sayi1 = random.Next(1, 6);
            sayi2 = random.Next(1, 6);
            zar1.Text = Convert.ToString(sayi1);
            zar2.Text = Convert.ToString(sayi2);

            if (tursayisi % 10 == 0)
            {
                tursayisi++;
                timer1.Stop();
            }


        }
    }
}
