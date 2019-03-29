namespace E6_Testare_DesktopApp
{
    partial class Conectare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conectare));
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnConectare = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblEroare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnInapoi.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnInapoi.Location = new System.Drawing.Point(952, 590);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(209, 62);
            this.btnInapoi.TabIndex = 4;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // btnConectare
            // 
            this.btnConectare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnConectare.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnConectare.Location = new System.Drawing.Point(683, 590);
            this.btnConectare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConectare.Name = "btnConectare";
            this.btnConectare.Size = new System.Drawing.Size(209, 62);
            this.btnConectare.TabIndex = 3;
            this.btnConectare.Text = "Conectare";
            this.btnConectare.UseVisualStyleBackColor = false;
            this.btnConectare.Click += new System.EventHandler(this.btnConectare_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(594, 212);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(237, 22);
            this.txtUser.TabIndex = 1;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(594, 309);
            this.txtParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(237, 22);
            this.txtParola.TabIndex = 2;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblUser.Location = new System.Drawing.Point(484, 197);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 41);
            this.lblUser.TabIndex = 23;
            this.lblUser.Text = "User";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblParola.Location = new System.Drawing.Point(484, 290);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(96, 41);
            this.lblParola.TabIndex = 22;
            this.lblParola.Text = "Parola";
            // 
            // lblEroare
            // 
            this.lblEroare.AutoSize = true;
            this.lblEroare.Location = new System.Drawing.Point(500, 391);
            this.lblEroare.Name = "lblEroare";
            this.lblEroare.Size = new System.Drawing.Size(0, 17);
            this.lblEroare.TabIndex = 24;
            // 
            // Conectare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1243, 693);
            this.Controls.Add(this.lblEroare);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnConectare);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Conectare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conectare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnInapoi;
        public System.Windows.Forms.Button btnConectare;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtParola;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblParola;
        public System.Windows.Forms.Label lblEroare;
    }
}