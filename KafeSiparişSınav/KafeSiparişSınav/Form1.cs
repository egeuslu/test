using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KafeSiparişSınav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Masa[] masalar = new Masa[15];

        private void Form1_Load(object sender, EventArgs e)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            DateTime tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            label4.Text = tarih.ToString("dd/MM/yyyy");
            label5.Text = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            label6.Text = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            listBox1.Items.Add("Ürün Adı \t\t\t Adet \t Fiyat\t");

            int no = 0;
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Button buton = new Button();
                    buton.BackColor = Color.DarkSalmon;
                    buton.Width = 40;
                    buton.Height = 40;
                    no++;
                    buton.Text = Convert.ToString(no);
                    buton.Left = 10 + (buton.Width) * (j);
                    buton.Top = 20 + (buton.Height) * (i);
                    buton.Click += buton_click;
                    masalarGbox.Controls.Add(buton);
                }
            }
        }
        private void buton_click(object sender, EventArgs e)
        {
            Button secbuton = sender as Button;
            secbuton.BackColor = Color.Aqua;
            siparisGbox.Enabled = true;
            masanonumber.Text = secbuton.Text;

        }

        private void siparisBtn_Click(object sender, EventArgs e)
        {
            Masa m = new Masa();
            m.masaNo = int.Parse(masanonumber.Text);


            Siparis sp = new Siparis();
            if (yemekCbox.SelectedItem != null)
            {
                sp.isim = yemekCbox.SelectedItem.ToString();
                sp.adet = Convert.ToInt32(yemeknumupdown.Value);
                m.siparisler.Add(sp);
            }

            sp = new Siparis();
            if (icecekCbox.SelectedItem != null)
            {
                sp.isim = icecekCbox.SelectedItem.ToString();
                sp.adet = Convert.ToInt32(iceceknumdown.Value);
                m.siparisler.Add(sp);
            }

            masalar[m.masaNo - 1] = m;
            listBox1.Items.Add(m);
        }
    }
}
