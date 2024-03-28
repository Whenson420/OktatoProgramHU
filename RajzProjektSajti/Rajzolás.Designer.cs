namespace RajzProjektSajti
{
    partial class Rajzolás
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
            this.delete = new System.Windows.Forms.Button();
            this.Thickness = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Thickness)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Turquoise;
            this.delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete.Location = new System.Drawing.Point(439, 457);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 28);
            this.delete.TabIndex = 0;
            this.delete.Text = "Törlés";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Thickness
            // 
            this.Thickness.BackColor = System.Drawing.Color.Turquoise;
            this.Thickness.Location = new System.Drawing.Point(461, 57);
            this.Thickness.Margin = new System.Windows.Forms.Padding(4);
            this.Thickness.Minimum = 1;
            this.Thickness.Name = "Thickness";
            this.Thickness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Thickness.Size = new System.Drawing.Size(56, 393);
            this.Thickness.TabIndex = 1;
            this.Thickness.Value = 1;
            this.Thickness.ValueChanged += new System.EventHandler(this.Thickness_ValueChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(402, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 46);
            this.button4.TabIndex = 8;
            this.button4.Text = "Vissza";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Rajzolás
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(537, 484);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Thickness);
            this.Controls.Add(this.delete);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rajzolás";
            this.Text = "Rajzolás";
            this.Load += new System.EventHandler(this.Rajzolás_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rajzolás_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Rajzolás_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rajzolás_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Thickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TrackBar Thickness;
        private System.Windows.Forms.Button button4;
    }
}