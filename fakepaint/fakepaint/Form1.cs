using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakepaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        ColorDialog colorDialog = new ColorDialog();
        int kalinlik = 3;
        int baslax, baslay;
        bool ciz;

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kalinlik = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
            baslax = e.X;
            baslay = e.Y;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            Pen P = new Pen(colorDialog.Color, kalinlik);
            Point point1 = new Point(baslax, baslay);
            Point Point2 = new Point(e.X, e.Y);
            if (ciz ==true)
            {
                g.DrawLine(P, point1, Point2);
                baslax = e.X;
                baslay = e.Y;
            }


        }
    }
}
