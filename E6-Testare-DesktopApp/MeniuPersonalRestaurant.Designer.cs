namespace E6_Testare_DesktopApp
{
    partial class MeniuPersonalRestaurant
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblBuna = new System.Windows.Forms.Label();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.lblNume.Location = new System.Drawing.Point(1083, 65);
            this.lblNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(63, 28);
            this.lblNume.TabIndex = 20;
            this.lblNume.Text = "label2";
            // 
            // lblBuna
            // 
            this.lblBuna.AutoSize = true;
            this.lblBuna.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.lblBuna.Location = new System.Drawing.Point(1012, 38);
            this.lblBuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuna.Name = "lblBuna";
            this.lblBuna.Size = new System.Drawing.Size(68, 28);
            this.lblBuna.TabIndex = 19;
            this.lblBuna.Text = "Buna, ";
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCont.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.btnCont.Location = new System.Drawing.Point(1088, 110);
            this.btnCont.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(121, 34);
            this.btnCont.TabIndex = 18;
            this.btnCont.Text = "Cont";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnInapoi.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnInapoi.Location = new System.Drawing.Point(885, 597);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(279, 76);
            this.btnInapoi.TabIndex = 27;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // MeniuPersonalRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1243, 693);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblBuna);
            this.Controls.Add(this.btnCont);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MeniuPersonalRestaurant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuPersonalRestaurant";
            this.Load += new System.EventHandler(this.MeniuPersonalRestaurant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblBuna;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnInapoi;
    }
}