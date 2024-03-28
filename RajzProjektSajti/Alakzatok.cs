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
    public partial class Alakzatok : Form
    {
        public Alakzatok()
        {
            InitializeComponent();
        }
        private void PanelVisibility()
        {
            KorPanel.Visible = alakzatok_combobox.Text == "Kör" ? true : false;
            NegyzetPanel.Visible = alakzatok_combobox.Text == "Négyzet" ? true : false;
            TeglalapPanel.Visible = alakzatok_combobox.Text == "Téglalap" ? true : false;
            RombuszPanel.Visible = alakzatok_combobox.Text == "Rombusz" ? true : false;
            RomboidPanel.Visible = alakzatok_combobox.Text == "Romboid" ? true : false;
            SzHatszogPanel.Visible = alakzatok_combobox.Text == "Szabályos hatszög" ? true : false;
            AltHatszogPanel.Visible = alakzatok_combobox.Text == "Általános hatszög" ? true : false;
            DerekTrapezPanel.Visible = alakzatok_combobox.Text == "Derékszögű trapéz" ? true : false;
            EgySzarTrapezPanel.Visible = alakzatok_combobox.Text == "Egyenlőszárú trapéz" ? true : false;
            EllipszisPanel.Visible = alakzatok_combobox.Text == "Ellipszis" ? true : false;
            Haromszogek_comboBox1.Visible = alakzatok_combobox.Text == "Háromszög" ? true : false;
            ESZHaromszogP.Visible = alakzatok_combobox.Text == "Háromszög" ? (Haromszogek_comboBox1.Text == "Egyenlő szárú háromszög" ? true : false) : false;
            EOHaromszogP.Visible = alakzatok_combobox.Text == "Háromszög" ? (Haromszogek_comboBox1.Text == "Egyenlő oldalú háromszög" ? true : false) : false;
            AHaromszogP.Visible = alakzatok_combobox.Text == "Háromszög" ? (Haromszogek_comboBox1.Text == "Általános háromszög" ? true : false) : false;
            DHaromszogP.Visible = alakzatok_combobox.Text == "Háromszög" ? (Haromszogek_comboBox1.Text == "Derékszögű háromszög" ? true : false) : false;

        }
        private void ChangePanel()
        {
            int x = rajztabla.Width;
            int y = rajztabla.Height;
            if (alakzatok_combobox.Text == "Háromszög")
            {
                if (Haromszogek_comboBox1.Text == "Derékszögű háromszög")
                {
                    rajztabla.Refresh();
                    Graphics g = rajztabla.CreateGraphics();
                    SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                    var shape = new Point[3];
                    shape[0] = new Point(10, y - 10);
                    shape[1] = new Point(x - 10, y - 10);
                    shape[2] = new Point(10, 10);
                    g.FillPolygon(ecset, shape);
                    ecset.Dispose();
                    g.Dispose();
                }
                if (Haromszogek_comboBox1.Text == "Általános háromszög")
                {
                    rajztabla.Refresh();
                    Graphics g = rajztabla.CreateGraphics();
                    SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                    var shape = new Point[3];
                    shape[0] = new Point(x - 50, y - 100);
                    shape[1] = new Point(120, y - 50);
                    shape[2] = new Point(x - 10, 10);
                    g.FillPolygon(ecset, shape);
                    ecset.Dispose();
                    g.Dispose();
                }
                if (Haromszogek_comboBox1.Text == "Egyenlő szárú háromszög")
                {
                    rajztabla.Refresh();
                    Graphics g = rajztabla.CreateGraphics();
                    SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                    var shape = new Point[3];
                    shape[0] = new Point(x - 120, y - 20);
                    shape[1] = new Point(120, y - 20);
                    shape[2] = new Point(x / 2, 20);
                    g.FillPolygon(ecset, shape);
                    ecset.Dispose();
                    g.Dispose();
                }
                if (Haromszogek_comboBox1.Text == "Egyenlő oldalú háromszög")
                {
                    rajztabla.Refresh();
                    Graphics g = rajztabla.CreateGraphics();
                    SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                    var shape = new Point[3];
                    shape[0] = new Point(x - 20, y - 20);
                    shape[1] = new Point(20, y - 20);
                    shape[2] = new Point(x / 2, 10);
                    g.FillPolygon(ecset, shape);
                    ecset.Dispose();
                    g.Dispose();
                }
            }
            if (alakzatok_combobox.Text == "Kör")
            {
                rajztabla.Refresh();
                Graphics g = rajztabla.CreateGraphics();
                SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                g.FillEllipse(ecset, 100, 80, 225, 225);
                ecset.Dispose();
                g.Dispose();
            }
            if (alakzatok_combobox.Text == "Négyzet")
            {
                rajztabla.Refresh();
                Graphics g = rajztabla.CreateGraphics();
                SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                g.FillRectangle(ecset, 100, 80, 225, 225);
                ecset.Dispose();
                g.Dispose();
            }
            if (alakzatok_combobox.Text == "Téglalap")
            {
                rajztabla.Refresh();
                Graphics g = rajztabla.CreateGraphics();
                SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                g.FillRectangle(ecset, 100, 80, 500, 250);
                ecset.Dispose();
                g.Dispose();
            }
            if (alakzatok_combobox.Text == "Rombusz")
            {
                rajztabla.Refresh();
                Graphics g = rajztabla.CreateGraphics();
                SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                var shape = new Point[4];
                shape[0] = new Point(x / 2, 10);
                shape[1] = new Point(x - 10, y / 2);
                shape[2] = new Point(x / 2, y - 10);
                shape[3] = new Point(10, y / 2);
                g.FillPolygon(ecset, shape);
                ecset.Dispose();
                g.Dispose();
            }
            if (alakzatok_combobox.Text == "Romboid")
            {
                rajztabla.Refresh();
                Graphics g = rajztabla.CreateGraphics();
                SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                var shape = new Point[4];
                shape[0] = new Point(10, y - 65);
                shape[1] = new Point(3 * x / 4 - 10, y - 65);
                shape[2] = new Point(x - 10, 65);
                shape[3] = new Point(x / 4 - 10, 65);
                g.FillPolygon(ecset, shape);
                ecset.Dispose();
                g.Dispose();
            }
            if (alakzatok_combobox.Text == "Szabályos hatszög")
            {
                rajztabla.Refresh();
                Graphics g = rajztabla.CreateGraphics();
                SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                var x_0 = 160;
                var y_0 = 200;

                var shape = new PointF[6];

                var r = 140;
                for (int a = 0; a < 6; a++)
                {
                    shape[a] = new PointF(
                        x_0 + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                        y_0 + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
                }

                g.FillPolygon(ecset, shape);
                ecset.Dispose();
                g.Dispose();
            }
            if (alakzatok_combobox.Text == "Általános hatszög")
            {
                rajztabla.Refresh();
                Graphics g = rajztabla.CreateGraphics();
                SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                var shape = new Point[6];
                shape[0] = new Point(x / 3 - 20, 10);
                shape[1] = new Point(2 * x / 3 + 20, 10);
                shape[2] = new Point(x - 10, y / 2);
                shape[3] = new Point(2 * x / 3 + 20, y - 10);
                shape[4] = new Point(x / 3 - 20, y - 10);
                shape[5] = new Point(10, y / 2);
                g.FillPolygon(ecset, shape);
                ecset.Dispose();
                g.Dispose();
            }
            if (alakzatok_combobox.Text == "Derékszögű trapéz")
            {
                rajztabla.Refresh();
                Graphics g = rajztabla.CreateGraphics();
                SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                var shape = new Point[4];
                shape[0] = new Point(10, 60);
                shape[1] = new Point(x / 2 + 10, 60);
                shape[2] = new Point(x - 10, y - 60);
                shape[3] = new Point(10, y - 60);
                g.FillPolygon(ecset, shape);
                ecset.Dispose();
                g.Dispose();
            }
            if (alakzatok_combobox.Text == "Egyenlőszárú trapéz")
            {
                rajztabla.Refresh();
                Graphics g = rajztabla.CreateGraphics();
                SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                var shape = new Point[4];
                shape[0] = new Point(120, 80);
                shape[1] = new Point(x - 120, 80);
                shape[2] = new Point(x - 10, y - 60);
                shape[3] = new Point(10, y - 60);
                g.FillPolygon(ecset, shape);
                ecset.Dispose();
                g.Dispose();
            }
            if (alakzatok_combobox.Text == "Ellipszis")
            {
                rajztabla.Refresh();
                Graphics g = rajztabla.CreateGraphics();
                SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
                g.FillEllipse(ecset, 100, 80, 200, 300);
                ecset.Dispose();
                g.Dispose();
            }

            
        }
        private void alakzatok_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangePanel();
            PanelVisibility();
        }
        private void Haromszogek_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangePanel();
            PanelVisibility();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
