﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaziHaneApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Musteri> MusteriList = new List<Musteri>();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Musteri mus = new Musteri();
            mus.Adi = TxtAdSoyad.Text;
            mus.Cinsiyet = TxtCinsiyet.Text;
            mus.OtobusTuru = TxtOtoTur.Text;
            MusteriList.Add(mus);
            listBox1.Items.Add(mus);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("İsim\t" + "Cinsiyet\t" + "OtobusTuru");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstiyor Musun?", "Onay Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstiyor Musun?", "Onay Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }
    }
}
