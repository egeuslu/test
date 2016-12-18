using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace webrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool UrlIsValid(String url)
        {
            bool result = false;

            try
            {
                IPHostEntry IpHost = Dns.Resolve(url);
            }

            catch (Exception)
            {
                result = false;                
            }

            return result;

        }

        private void GitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UrlIsValid(URLTxt.Text))
                {
                    Tarayici.Navigate(URLTxt.Text);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Site ismi yanlış");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Takvim_ValueChanged(object sender, EventArgs e)
        {
            YasTxt.Text =Convert.ToInt32(Math.Floor(DateTime.Now.Subtract(Takvim.Value).TotalDays / 365.25)).ToString();
        }
    }
}
