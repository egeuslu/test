using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzayYolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Left:
                    SpaceShip.Left -= 10;
                    break;

                case Keys.Right:
                    SpaceShip.Left += 10;
                    break;

                case Keys.Up:
                    SpaceShip.Top -= 10;
                    break;
                case Keys.Down:
                    SpaceShip.Top += 10;
                    break;
                case Keys.Space:
                    bomb.Visible = true;
                    timer1.Start();
                    bomb.Left += 10;
                    bomb.Location = new Point(SpaceShip.Location.X, SpaceShip.Location.Y);    
                    break;
                  
                default:
                    break;
            }
            
            int genislik = Form1.ActiveForm.Width;
            if (SpaceShip.Location.X > genislik - SpaceShip.Width)
            {
                MessageBox.Show("Sinir Asildi");
                SpaceShip.Location = new Point(0, 0);
            }
            int uzunluk = Form1.ActiveForm.Height;
            if (SpaceShip.Location.Y > uzunluk - SpaceShip.Height)
            {
                MessageBox.Show("Sinir Asildi");
                SpaceShip.Location = new Point(0, 0);

            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bomb.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int genislik = Form1.ActiveForm.Width;
            int uzunluk = Form1.ActiveForm.Height;

            if (bomb.Location.X < genislik-bomb.Width)
            {
                bomb.Left += 10;
            }
            else
            {
                timer1.Stop();
                bomb.Visible = false;
            }
        }
    }
}


