﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fahelloworld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("selamlar!!!!");
        }

        private void MerhabaDunyaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdSoyadTxtB.Text + "\n" + SifreTxtB.Text);
        }
    }
}
