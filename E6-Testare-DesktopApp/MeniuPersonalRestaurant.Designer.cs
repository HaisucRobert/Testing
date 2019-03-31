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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuPersonalRestaurant));
            this.Image = new System.Windows.Forms.PictureBox();
            this.btn_preparate = new System.Windows.Forms.Button();
            this.btn_meniuri = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblBuna = new System.Windows.Forms.Label();
            this.btnCont = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.Image = ((System.Drawing.Image)(resources.GetObject("Image.Image")));
            this.Image.Location = new System.Drawing.Point(230, 77);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(369, 245);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 40;
            this.Image.TabStop = false;
            // 
            // btn_preparate
            // 
            this.btn_preparate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_preparate.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btn_preparate.Location = new System.Drawing.Point(22, 64);
            this.btn_preparate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_preparate.Name = "btn_preparate";
            this.btn_preparate.Size = new System.Drawing.Size(166, 48);
            this.btn_preparate.TabIndex = 39;
            this.btn_preparate.Text = "Preparate";
            this.btn_preparate.UseVisualStyleBackColor = false;
            this.btn_preparate.Click += new System.EventHandler(this.btn_preparate_Click_1);
            // 
            // btn_meniuri
            // 
            this.btn_meniuri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_meniuri.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btn_meniuri.Location = new System.Drawing.Point(22, 140);
            this.btn_meniuri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_meniuri.Name = "btn_meniuri";
            this.btn_meniuri.Size = new System.Drawing.Size(166, 48);
            this.btn_meniuri.TabIndex = 38;
            this.btn_meniuri.Text = "Meniuri";
            this.btn_meniuri.UseVisualStyleBackColor = false;
            this.btn_meniuri.Click += new System.EventHandler(this.btn_meniuri_Click_1);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnInapoi.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnInapoi.Location = new System.Drawing.Point(597, 329);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(166, 48);
            this.btnInapoi.TabIndex = 37;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click_1);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.lblNume.Location = new System.Drawing.Point(649, 55);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 22);
            this.lblNume.TabIndex = 36;
            this.lblNume.Text = "label2";
            // 
            // lblBuna
            // 
            this.lblBuna.AutoSize = true;
            this.lblBuna.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.lblBuna.Location = new System.Drawing.Point(602, 33);
            this.lblBuna.Name = "lblBuna";
            this.lblBuna.Size = new System.Drawing.Size(55, 22);
            this.lblBuna.TabIndex = 35;
            this.lblBuna.Text = "Buna, ";
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCont.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.btnCont.Location = new System.Drawing.Point(672, 84);
            this.btnCont.Margin = new System.Windows.Forms.Padding(4);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(91, 28);
            this.btnCont.TabIndex = 34;
            this.btnCont.Text = "Cont";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click_1);
            // 
            // MeniuPersonalRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(932, 563);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.btn_preparate);
            this.Controls.Add(this.btn_meniuri);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblBuna);
            this.Controls.Add(this.btnCont);
            this.Name = "MeniuPersonalRestaurant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuPersonalRestaurant";
            this.Load += new System.EventHandler(this.MeniuPersonalRestaurant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Button btn_preparate;
        private System.Windows.Forms.Button btn_meniuri;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblBuna;
        private System.Windows.Forms.Button btnCont;
    }
}