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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int senddata;

        List<musteri> musteriler = new List<musteri>();
        List<musteri> odenenler = new List<musteri>();
        private musteri mus;

        public void EkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                musteri mus = new musteri();
                mus.AboneNo = int.Parse(AboneNoTxt.Text);
                mus.adi = AdSoyadTxt.Text;
                mus.BSayaci = int.Parse(BSayacTxt.Text);
                mus.ASayaci = int.Parse(ASayacTxt.Text);
                string musteri = EvRBtn.Checked == true ? "Ev" : "Kurum";
                mus.EvKurum = musteri;
                musteriler.Add(mus);
                AboneLbx.Items.Add(mus);
            }
            catch (Exception)
            {
                MessageBox.Show("hata var hata!!!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AboneLbx.Items.Add("İsim\t" + "Kuruluş\t" + "İlk Fatura\t" + "Son Fatura" + "Abone No");
        }

        private void OdemeBtn_Click(object sender, EventArgs e)
        {


            if (AboneLbx.Items.Count == 1)
            {
                MessageBox.Show("Abone Yok la");
            }

            else if (AboneLbx.Items.Count > 1)
            {
                DialogResult dialogResult = MessageBox.Show("Ödeme Yapmak İstediğinizden eminmisiniz\n", "Ödeme", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    musteri mus = (musteri)OdenenlerLbx.SelectedItem;
                    Form2 odemeform = new Form2();
                    odemeform.Show();
                    odemeform.abonenotextbox.Text = musteriler[senddata].AboneNo.ToString();
                    odemeform.adsoyadtextbox.Text = musteriler[senddata].adi.ToString();
                    odemeform.oncekisayactextbox.Text = musteriler[senddata].BSayaci.ToString();
                    odemeform.sorankisayactextbox.Text = musteriler[senddata].ASayaci.ToString();
                    odemeform.evkurumtextbox.Text = musteriler[senddata].EvKurum.ToString();

                    if (musteriler[senddata].EvKurum.ToString() == "Ev")
                    {
                        double totalborc = (musteriler[senddata].ASayaci - musteriler[senddata].BSayaci) * 0.3;
                        odemeform.totalborctextbox.Text = totalborc.ToString();
                    }
                    else
                    {
                        double totalborc = (musteriler[senddata].ASayaci - musteriler[senddata].BSayaci) * 0.5;
                        odemeform.totalborctextbox.Text = totalborc.ToString();
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

        }

        private void AboneLbx_DoubleClick(object sender, EventArgs e)
        {
            musteri mus = new musteri();
            AboneLbx.Items.Remove(AboneLbx.SelectedItem);
        }

        private void AboneLbx_MouseClick(object sender, MouseEventArgs e)
        {
            senddata = AboneLbx.SelectedIndex - 1;
        }
    }
}

