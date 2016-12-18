using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şans_Topu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
            Random random = new Random();
            int rasgeleSayi;
        List<int> Sayilar = new List<int>(6);
           //int[] Sayilar = new int[6];
            int sayac = 0;
           int tursayisi = 1;
           
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tursayisi % 10 ==0)
            {
                timer1.Stop();
                Sayilar.Sort();
            }
            else
            {
                Sayilar.Clear();
            }
            if (tursayisi == 20) 
            {
                timer1.Interval = 250;
            }
            while (sayac < 6)
            {
                rasgeleSayi = random.Next(1, 50);
                if (!Sayilar.Contains(rasgeleSayi))
                {
                    Sayilar.Add(rasgeleSayi);
                    sayac++;
                }
            }
              

            label1.Text = Sayilar[0].ToString();
            label2.Text = Sayilar[1].ToString();
            label3.Text = Sayilar[2].ToString();
            label4.Text = Sayilar[3].ToString();
            label5.Text = Sayilar[4].ToString();
            label6.Text = Sayilar[5].ToString();
            sayac = 0;
            tursayisi++;
        }

    }
}

