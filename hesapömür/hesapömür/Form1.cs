using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapömür
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HesaplaBtn_Click(object sender, EventArgs e)
        {
            string yapilan = isTxtB.Text;
            int saat = int.Parse(saaatTxtB.Text);
            double oran = ((double) saat / 24);
            MessageBox.Show((80 * oran) + " yıl " + isTxtB.Text + " yapmissin ");
           
        }
    }
}
