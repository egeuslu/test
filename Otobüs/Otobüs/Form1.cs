using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobüs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int otobus;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            otobus = int.Parse(comboBox1.SelectedItem.ToString());

            if (otobus.ToString() == "45")
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j !=4 && i !=2)
                        {
                    
                        Button btn = new Button();
                        btn.Width = 25;
                        btn.Height = 25;
                        btn.BackColor = Color.Blue;
                        btn.Location = new Point(20*j, 50*i);
                        
                        this.Controls.Add(btn);
                        }
                    }
                }
                
            }
        }
     }
  }
