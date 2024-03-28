using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RajzProjektSajti
{
    public partial class Rajzolás : Form
    {
        public Rajzolás()
        {
            InitializeComponent();
        }
        bool rajzolj = false;
        int xKezdo, yKezdo,BSize = 1;
        private void Rajzolás_Load(object sender, EventArgs e)
        {
        }
        private void Rajzolás_MouseUp(object sender, MouseEventArgs e)
        {
            rajzolj = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Refresh();
        }
        private void Rajzolás_MouseDown(object sender, MouseEventArgs e)
        {
            rajzolj = true;
            xKezdo = e.X;
            yKezdo = e.Y;
        }
        private void Thickness_ValueChanged(object sender, EventArgs e)
        {
            BSize = Thickness.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Rajzolás_MouseMove(object sender, MouseEventArgs e)
        {
            if (rajzolj)
            {
                Graphics g = CreateGraphics();
                Pen blackPen = new Pen(Color.Black, BSize);
                g.DrawLine(blackPen, xKezdo, yKezdo, e.X, e.Y);
                xKezdo = e.X;
                yKezdo = e.Y;
                g.Dispose();
            }
        }
    }
}
