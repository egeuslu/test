using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        List<String> İsimler = new List<string>() { "Seçkin", "Ufuk", "Özgür", "Doğan", "Kaan", "Ege", "Temmuz", "Erdem", "Metin", "Alper" };
        Random rnd = new Random();
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int index = rnd.Next(0, 10);
            string isim = İsimler[index];

            Graphics g = CreateGraphics();

            int red = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);

            int x = rnd.Next(10, this.Width - 50);
            int y = rnd.Next(10, this.Height - 50);

            int fontSize = rnd.Next(20, 40);
            g.DrawString(isim, new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold), new SolidBrush(Color.FromArgb(red, green, blue)), x, y);

            if (sayac == 500)
            {

                this.Invalidate();
                sayac = 0;
            }
            sayac++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.WindowState = FormWindowState.Maximized;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar == (char)Keys.F11)
            {
                case  :                    
                    this.TopMost = true;
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                    break;
                default:
                    break;
            }
        }
    }
}
