using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ogrenci ogr1 = new ogrenci();
        ogrenci ogr2 = new ogrenci();
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            ogr1.AdSoyad = "Yavuz Gedik";
            ogr1.OgrNo = rnd.Next(1,100);

            ogr2.AdSoyad = "Seçkin Umur";
            ogr2.OgrNo = rnd.Next(1, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ogr1.AdSoyad + " " + ogr1.OgrNo + "\n " + ogr2.AdSoyad + " " +ogr2.OgrNo );
        }
    }
}
