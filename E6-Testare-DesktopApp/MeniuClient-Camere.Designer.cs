namespace E6_Testare_DesktopApp
{
    partial class MeniuClient_Camere
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
            this.imagePXB = new System.Windows.Forms.PictureBox();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaturi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtSpecificatii = new System.Windows.Forms.TextBox();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePXB)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePXB
            // 
            this.imagePXB.Location = new System.Drawing.Point(410, 127);
            this.imagePXB.Name = "imagePXB";
            this.imagePXB.Size = new System.Drawing.Size(510, 257);
            this.imagePXB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePXB.TabIndex = 0;
            this.imagePXB.TabStop = false;
            this.imagePXB.Click += new System.EventHandler(this.image_Click);
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(135, 164);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(195, 21);
            this.cboCamera.TabIndex = 1;
            this.cboCamera.SelectedIndexChanged += new System.EventHandler(this.cboCamera_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(42, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(42, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paturi";
            // 
            // txtPaturi
            // 
            this.txtPaturi.Location = new System.Drawing.Point(135, 216);
            this.txtPaturi.Name = "txtPaturi";
            this.txtPaturi.Size = new System.Drawing.Size(195, 20);
            this.txtPaturi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(42, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Specificatii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(42, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pret";
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(135, 313);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(195, 20);
            this.txtPret.TabIndex = 7;
            // 
            // txtSpecificatii
            // 
            this.txtSpecificatii.Location = new System.Drawing.Point(135, 267);
            this.txtSpecificatii.Name = "txtSpecificatii";
            this.txtSpecificatii.Size = new System.Drawing.Size(195, 20);
            this.txtSpecificatii.TabIndex = 8;
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnInapoi.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnInapoi.Location = new System.Drawing.Point(710, 488);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(209, 62);
            this.btnInapoi.TabIndex = 9;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(83, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Rezerva o camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MeniuClient_Camere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(932, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.txtSpecificatii);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPaturi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.imagePXB);
            this.Name = "MeniuClient_Camere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuClient_Camere";
            this.Load += new System.EventHandler(this.MeniuClient_Camere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePXB;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaturi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtSpecificatii;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Button button1;
    }
}