namespace RajzProjektSajti
{
    partial class jatek
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.rajztabla = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helyesL = new System.Windows.Forms.Label();
            this.hamisL = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rajztabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Találd ki az alakzatot";
            // 
            // rajztabla
            // 
            this.rajztabla.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rajztabla.Location = new System.Drawing.Point(150, 58);
            this.rajztabla.Name = "rajztabla";
            this.rajztabla.Size = new System.Drawing.Size(632, 376);
            this.rajztabla.TabIndex = 1;
            this.rajztabla.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(704, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // helyesL
            // 
            this.helyesL.AutoSize = true;
            this.helyesL.Location = new System.Drawing.Point(12, 24);
            this.helyesL.Name = "helyesL";
            this.helyesL.Size = new System.Drawing.Size(53, 16);
            this.helyesL.TabIndex = 5;
            this.helyesL.Text = "Helyes:";
            // 
            // hamisL
            // 
            this.hamisL.AutoSize = true;
            this.hamisL.Location = new System.Drawing.Point(131, 24);
            this.hamisL.Name = "hamisL";
            this.hamisL.Size = new System.Drawing.Size(49, 16);
            this.hamisL.TabIndex = 6;
            this.hamisL.Text = "Hamis:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(792, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 46);
            this.button4.TabIndex = 7;
            this.button4.Text = "Vissza";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // jatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(927, 558);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.hamisL);
            this.Controls.Add(this.helyesL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rajztabla);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "jatek";
            this.Text = "jatek";
            this.Load += new System.EventHandler(this.jatek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rajztabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox rajztabla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label helyesL;
        private System.Windows.Forms.Label hamisL;
        private System.Windows.Forms.Button button4;
    }
}