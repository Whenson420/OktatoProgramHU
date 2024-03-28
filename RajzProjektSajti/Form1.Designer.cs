namespace RajzProjektSajti
{
    partial class Kezdőlap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Alakzatok = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jatek = new System.Windows.Forms.Button();
            this.rajzolas_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üdvözöllek";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(189, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 73);
            this.panel1.TabIndex = 1;
            // 
            // Alakzatok
            // 
            this.Alakzatok.BackColor = System.Drawing.Color.Cyan;
            this.Alakzatok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Alakzatok.Location = new System.Drawing.Point(48, 27);
            this.Alakzatok.Margin = new System.Windows.Forms.Padding(4);
            this.Alakzatok.Name = "Alakzatok";
            this.Alakzatok.Size = new System.Drawing.Size(153, 59);
            this.Alakzatok.TabIndex = 1;
            this.Alakzatok.Text = "Alakzatok";
            this.Alakzatok.UseVisualStyleBackColor = false;
            this.Alakzatok.Click += new System.EventHandler(this.Alakzatok_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.jatek);
            this.panel2.Controls.Add(this.rajzolas_button);
            this.panel2.Controls.Add(this.Alakzatok);
            this.panel2.Location = new System.Drawing.Point(180, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 427);
            this.panel2.TabIndex = 2;
            // 
            // jatek
            // 
            this.jatek.BackColor = System.Drawing.Color.Cyan;
            this.jatek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jatek.Location = new System.Drawing.Point(48, 303);
            this.jatek.Margin = new System.Windows.Forms.Padding(4);
            this.jatek.Name = "jatek";
            this.jatek.Size = new System.Drawing.Size(153, 59);
            this.jatek.TabIndex = 3;
            this.jatek.Text = "Játék";
            this.jatek.UseVisualStyleBackColor = false;
            this.jatek.Click += new System.EventHandler(this.jatek_Click);
            // 
            // rajzolas_button
            // 
            this.rajzolas_button.BackColor = System.Drawing.Color.Cyan;
            this.rajzolas_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rajzolas_button.Location = new System.Drawing.Point(48, 159);
            this.rajzolas_button.Margin = new System.Windows.Forms.Padding(4);
            this.rajzolas_button.Name = "rajzolas_button";
            this.rajzolas_button.Size = new System.Drawing.Size(153, 59);
            this.rajzolas_button.TabIndex = 2;
            this.rajzolas_button.Text = "Rajzolás";
            this.rajzolas_button.UseVisualStyleBackColor = false;
            this.rajzolas_button.Click += new System.EventHandler(this.rajzolas_button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(486, 533);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 46);
            this.button4.TabIndex = 8;
            this.button4.Text = "Kilépés";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Kezdőlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(621, 591);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Kezdőlap";
            this.Text = "Kezdőlap";
            this.Load += new System.EventHandler(this.Kezdőlap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Alakzatok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button jatek;
        private System.Windows.Forms.Button rajzolas_button;
        private System.Windows.Forms.Button button4;
    }
}

