using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RajzProjektSajti
{
    public partial class Kezdőlap : Form
    {
        public Kezdőlap()
        {
            InitializeComponent();
        }

        private void rajzolas_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Rajzolás rajzolás = new Rajzolás();
            rajzolás.Closed += (s, args) => this.Visible = true;
            rajzolás.Show();
        }

        private void Alakzatok_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Alakzatok alak = new Alakzatok();
            alak.Closed += (s, args) => this.Visible = true;
            alak.Show();
        }

        private void jatek_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            jatek game = new jatek();
            game.Closed += (s, args) => this.Visible = true;
            game.Show();
        }

        private void Kezdőlap_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
