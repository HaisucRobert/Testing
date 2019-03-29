namespace E6_Testare_DesktopApp
{
    partial class MeniuClient_Hotel
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
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnCamere = new System.Windows.Forms.Button();
            this.btnRezervari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnInapoi.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnInapoi.Location = new System.Drawing.Point(699, 471);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(209, 62);
            this.btnInapoi.TabIndex = 5;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // btnCamere
            // 
            this.btnCamere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCamere.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnCamere.Location = new System.Drawing.Point(334, 207);
            this.btnCamere.Margin = new System.Windows.Forms.Padding(4);
            this.btnCamere.Name = "btnCamere";
            this.btnCamere.Size = new System.Drawing.Size(209, 62);
            this.btnCamere.TabIndex = 6;
            this.btnCamere.Text = "Camere";
            this.btnCamere.UseVisualStyleBackColor = false;
            this.btnCamere.Click += new System.EventHandler(this.btnCamere_Click);
            // 
            // btnRezervari
            // 
            this.btnRezervari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRezervari.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnRezervari.Location = new System.Drawing.Point(334, 302);
            this.btnRezervari.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezervari.Name = "btnRezervari";
            this.btnRezervari.Size = new System.Drawing.Size(209, 62);
            this.btnRezervari.TabIndex = 7;
            this.btnRezervari.Text = "Rezervari";
            this.btnRezervari.UseVisualStyleBackColor = false;
            this.btnRezervari.Click += new System.EventHandler(this.btnRezervari_Click);
            // 
            // MeniuClient_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(932, 563);
            this.Controls.Add(this.btnRezervari);
            this.Controls.Add(this.btnCamere);
            this.Controls.Add(this.btnInapoi);
            this.Name = "MeniuClient_Hotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuClient_Hotel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Button btnCamere;
        private System.Windows.Forms.Button btnRezervari;
    }
}