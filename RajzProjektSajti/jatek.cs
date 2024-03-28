using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace RajzProjektSajti
{
    public partial class jatek : Form
    {
        public jatek()
        {
            InitializeComponent();
        }
        private void jatek_Load(object sender, EventArgs e)
        {
            Generate();
        }
        private int helyes = 0, hamis = 0;
        private bool Eltalalt = false;
        private Random rng = new Random();
        private string nextShape = "Ellipszis";
        private bool megoldas = false;
        private bool[] alakzatok = new bool[14];
        private void Reset()
        {
            rajztabla.Refresh();
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            megoldas = false;
            for (int i = 0; i < 14; i++)
                alakzatok[i] = false;
        }
        private void SetButtonText(string Text)
        {
            bool success = false;
            while (!success)
            {
                int i = rng.Next(1,4);
                switch (i)
                {
                    case 1:
                        if (button1.Text == " ")
                        {
                            success = true;
                            if (megoldas == false)
                            {
                                button1.Text = nextShape;
                                megoldas = true;
                                break;
                            }
                            button1.Text = Text;
                        }
                        break;
                    case 2:
                        if (button2.Text == " ")
                        {
                            success = true;
                            if (megoldas == false)
                            {
                                button2.Text = nextShape;
                                megoldas = true;
                                break;
                            }
                            button2.Text = Text;
                        }
                        break;
                    case 3:
                        if (button3.Text == " ")
                        {
                            success = true;
                            if (megoldas == false)
                            {
                                button3.Text = nextShape;
                                megoldas = true;
                                break;
                            }
                            button3.Text = Text;
                        }
                        break;
                }
            }
        }
        private void GenerateShape(bool fButtons)
        {
            int i = rng.Next(1,15);
            if(fButtons)
                while (alakzatok[i-1]  == true)
                    i = rng.Next(1,15);
            switch (i)
            {
                case 1:
                    if (fButtons)
                    {
                        SetButtonText("Derékszögű háromszög");
                        alakzatok[0] = true;
                    }
                    else
                        nextShape = "Derékszögű háromszög";
                    break;
                case 2:
                    if (fButtons)
                    {
                        SetButtonText("Általános háromszög");
                        alakzatok[1] = true;
                    }
                    else
                    {
                        nextShape = "Általános háromszög";
                    }
                    break;
                case 3:
                    if (fButtons)
                    {
                        SetButtonText("Egyenlő szárú háromszög");
                        alakzatok[2] = true;
                    }
                    else
                    {
                        nextShape = "Egyenlő szárú háromszög";
                    }
                    break;
                case 4:
                    if (fButtons)
                    {
                        SetButtonText("Egyenlő oldalú háromszög");
                        alakzatok[3] = true;
                    }
                    else
                    {
                        nextShape = "Egyenlő oldalú háromszög";
                    }
                    break;
                case 5:
                    if (fButtons)
                    {
                        SetButtonText("Kör");
                        alakzatok[4] = true;
                    }
                    else
                    {
                        nextShape = "Kör";
                    }
                    break;
                case 6:
                    if (fButtons)
                    {
                        SetButtonText("Négyzet");
                        alakzatok[5] = true;
                    }
                    else
                    {
                        nextShape = "Négyzet";
                    }
                    break;
                case 7:
                    if (fButtons)
                    {
                        SetButtonText("Téglalap");
                        alakzatok[6] = true;
                    }
                    else
                    {
                        nextShape = "Téglalap";
                    }
                    break;
                case 8:
                    if (fButtons)
                    {
                        SetButtonText("Rombusz");
                        alakzatok[7] = true;
                    }
                    else
                    {
                        nextShape = "Rombusz";
                    }
                    break;
                case 9:
                    if (fButtons)
                    {
                        SetButtonText("Romboid");
                        alakzatok[8] = true;
                    }
                    else
                    {
                        nextShape = "Romboid";
                    }
                    break;
                case 10:
                    if (fButtons)
                    {
                        SetButtonText("Szabályos hatszög");
                        alakzatok[9] = true;
                    }
                    else
                    {
                        nextShape = "Szabályos hatszög";
                    }
                    break;
                case 11:
                    if (fButtons)
                    {
                        SetButtonText("Általános hatszög");
                        alakzatok[10] = true;
                    }
                    else
                    {
                        nextShape = "Általános hatszög";
                    }
                    break;
                case 12:
                    if (fButtons)
                    {
                        SetButtonText("Derékszögű trapéz");
                        alakzatok[11] = true;
                    }
                    else
                    {
                        nextShape = "Derékszögű trapéz";
                    }
                    break;
                case 13:
                    if (fButtons)
                    {
                        SetButtonText("Egyenlőszárú trapéz");
                        alakzatok[12] = true; 
                    }
                    else
                    {
                        nextShape = "Egyenlőszárú trapéz";
                    }
                    break;
                case 14:
                    if (fButtons)
                    {
                        SetButtonText("Ellipszis");
                        alakzatok[13] = true;
                    }
                    else
                    {
                        nextShape = "Ellipszis";
                    }
                    break;
                
            }
                
        }
        private void DrawShapes()
        {
            int x = rajztabla.Width;
            int y = rajztabla.Height;
            Graphics g = rajztabla.CreateGraphics();
            SolidBrush ecset = new SolidBrush(Color.FromArgb(120, 120, 120));
            if (nextShape == "Derékszögű háromszög") 
                {
                    
        
                    var shape = new Point[3];
                    shape[0] = new Point(10, y - 10);
                    shape[1] = new Point(x - 10, y - 10);
                    shape[2] = new Point(10, 10);
                    g.FillPolygon(ecset, shape);
                    ecset.Dispose();
                    g.Dispose();
                }
            if (nextShape == "Általános háromszög") 
                {

                    
        
                    var shape = new Point[3];
                    shape[0] = new Point(x - 50, y - 100);
                    shape[1] = new Point(120, y - 50);
                    shape[2] = new Point(x - 10, 10);
                    g.FillPolygon(ecset, shape);
                    ecset.Dispose();
                    g.Dispose();
                }
            if (nextShape == "Egyenlő szárú háromszög") 
                {

                    
        
                    var shape = new Point[3];
                    shape[0] = new Point(x - 120, y - 20);
                    shape[1] = new Point(120, y - 20);
                    shape[2] = new Point(x / 2, 20);
                    g.FillPolygon(ecset, shape);
                    ecset.Dispose();
                    g.Dispose();
                }
            if (nextShape == "Egyenlő oldalú háromszög") 
                {

                    
        
                    var shape = new Point[3];
                    shape[0] = new Point(x - 20, y - 20);
                    shape[1] = new Point(20, y - 20);
                    shape[2] = new Point(x / 2, 10);
                    g.FillPolygon(ecset, shape);
                    ecset.Dispose();
                    g.Dispose();
                }
            if (nextShape == "Kör")
            {

                g.FillEllipse(ecset, x / 3, y / 3, 200, 200);
                ecset.Dispose();
                g.Dispose();
            }
            if (nextShape == "Négyzet")
            {

                g.FillRectangle(ecset, x / 3, y / 3, 200, 200);           
                ecset.Dispose();
                g.Dispose();
            }
            if (nextShape == "Téglalap")
            {
                
                
    
                var shape = new Point[4];
                shape[0] = new Point(10, 80);
                shape[1] = new Point(x - 10, 80);
                shape[2] = new Point(x - 10, y - 80);
                shape[3] = new Point(10, y - 80);
                g.FillPolygon(ecset,shape);
                ecset.Dispose();
                g.Dispose();
            }
            if (nextShape == "Rombusz")
            {
                
                
    
                var shape = new Point[4];
                shape[0] = new Point(x / 2, 10);
                shape[1] = new Point(x - 10, y / 2);
                shape[2] = new Point(x / 2, y - 10);
                shape[3] = new Point(10, y / 2);
                g.FillPolygon(ecset, shape);
                ecset.Dispose();
                g.Dispose();
            }
            if (nextShape == "Romboid")
            {
                
                
    
                var shape = new Point[4];
                shape[0] = new Point(10, y - 65);
                shape[1] = new Point(3 * x / 4 - 10, y - 65);
                shape[2] = new Point(x - 10, 65);
                shape[3] = new Point(x / 4 - 10, 65);
                g.FillPolygon(ecset, shape);
                ecset.Dispose();
                g.Dispose();
            }
            if (nextShape == "Szabályos hatszög")
            {
                
                
    
                var x_0 = x/2;
                var y_0 = y/2;

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
            if (nextShape == "Általános hatszög")
            {
                
                
    
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
            if (nextShape == "Derékszögű trapéz")
            {
                
                
    
                var shape = new Point[4];
                shape[0] = new Point(10, 60);
                shape[1] = new Point(x / 2 + 10, 60);
                shape[2] = new Point(x - 10, y - 60);
                shape[3] = new Point(10, y - 60);
                g.FillPolygon(ecset, shape);
                ecset.Dispose();
                g.Dispose();
            }
            if (nextShape == "Egyenlőszárú trapéz")
            {
                
                
    
                var shape = new Point[4];
                shape[0] = new Point(120, 80);
                shape[1] = new Point(x - 120, 80);
                shape[2] = new Point(x - 10, y - 60);
                shape[3] = new Point(10, y - 60);
                g.FillPolygon(ecset, shape);
                ecset.Dispose();
                g.Dispose();
            }
            if (nextShape == "Ellipszis")
            {
                
                g.FillEllipse(ecset, 100, 80, x - 40, y - 40);
                ecset.Dispose();
                g.Dispose();
            }
        }
        private void Generate()
        {
            Reset();
            //Legeneralja az alakzatot
            GenerateShape(false);
            DrawShapes();
            //Legeneralja a gombokat
            for(int i = 0; i < 3; i++)
                GenerateShape(true);
            Eltalalt = false;
        }
        private void GameManagger()
        {
            if (!Eltalalt)
            {
                hamis++;
            }
            else
            {
                helyes++;
                Generate();
            }
            helyesL.Text = "Helyes:" + helyes.ToString();
            hamisL.Text = "Helytelen:" + hamis.ToString();
            if (helyes == 20)
            {
                MessageBox.Show("Nyertél! Helyes:20 Helytelen:" + hamis, "Winner winner chicken dinner", MessageBoxButtons.OK);
                this.Close();
            }
            if (hamis == 8)
            {
                MessageBox.Show("Vesztettél! Helyes:" + helyes + " Helytelen:8", "L", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nextShape == button1.Text)
                Eltalalt = true;
            GameManagger();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nextShape == button2.Text)
                Eltalalt = true;
            GameManagger();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nextShape == button3.Text)
                Eltalalt = true;
            GameManagger();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
