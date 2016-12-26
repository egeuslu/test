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
        List<musteri> musteriler = new List<musteri>();

        private void EkleBtn_Click(object sender, EventArgs e)
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
                MessageBox.Show("adam ol");
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
                DialogResult dialogResult = MessageBox.Show("Ödeme Yapmak İstediğinizden eminmisiniz\n"+ AboneLbx.SelectedItem, "Ödeme", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
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
    }
}

