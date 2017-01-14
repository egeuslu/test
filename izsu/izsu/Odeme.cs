using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izsu
{
    public partial class Form2 : Form
    {
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        public Form2()
        
        {
            InitializeComponent();

        }

        private void ödemeyapBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Borcunuz Ödenmiştir");
            this.Hide();      
        }

       
    }
}

