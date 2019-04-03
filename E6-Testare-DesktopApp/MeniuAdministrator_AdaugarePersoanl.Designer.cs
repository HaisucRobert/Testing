namespace E6_Testare_DesktopApp
{
    partial class MeniuAdministrator_AdaugarePersoanl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuAdministrator_AdaugarePersoanl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnStergerePersonal = new System.Windows.Forms.Button();
            this.lblErrorNume = new System.Windows.Forms.Label();
            this.lblErrorParola = new System.Windows.Forms.Label();
            this.lblErrorUser = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboFunctie = new System.Windows.Forms.ComboBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblFunctie = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.LblCaracter = new System.Windows.Forms.Label();
            this.lblCifra = new System.Windows.Forms.Label();
            this.lblLiteraMica = new System.Windows.Forms.Label();
            this.lblLiteraMare = new System.Windows.Forms.Label();
            this.lblDimensiune = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 614);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(865, 76);
            this.dataGridView1.TabIndex = 77;
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAfisare.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnAfisare.Location = new System.Drawing.Point(404, 545);
            this.btnAfisare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(240, 62);
            this.btnAfisare.TabIndex = 76;
            this.btnAfisare.Text = "Afisare angajati";
            this.btnAfisare.UseVisualStyleBackColor = false;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click_1);
            // 
            // btnStergerePersonal
            // 
            this.btnStergerePersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStergerePersonal.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnStergerePersonal.Location = new System.Drawing.Point(16, 511);
            this.btnStergerePersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStergerePersonal.Name = "btnStergerePersonal";
            this.btnStergerePersonal.Size = new System.Drawing.Size(209, 96);
            this.btnStergerePersonal.TabIndex = 75;
            this.btnStergerePersonal.Text = "Stergere Personal";
            this.btnStergerePersonal.UseVisualStyleBackColor = false;
            this.btnStergerePersonal.Click += new System.EventHandler(this.btnStergerePersonal_Click_1);
            // 
            // lblErrorNume
            // 
            this.lblErrorNume.AutoSize = true;
            this.lblErrorNume.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorNume.Location = new System.Drawing.Point(969, 105);
            this.lblErrorNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorNume.Name = "lblErrorNume";
            this.lblErrorNume.Size = new System.Drawing.Size(0, 17);
            this.lblErrorNume.TabIndex = 74;
            this.lblErrorNume.Visible = false;
            // 
            // lblErrorParola
            // 
            this.lblErrorParola.AutoSize = true;
            this.lblErrorParola.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorParola.Location = new System.Drawing.Point(965, 382);
            this.lblErrorParola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorParola.Name = "lblErrorParola";
            this.lblErrorParola.Size = new System.Drawing.Size(0, 17);
            this.lblErrorParola.TabIndex = 73;
            this.lblErrorParola.Visible = false;
            // 
            // lblErrorUser
            // 
            this.lblErrorUser.AutoSize = true;
            this.lblErrorUser.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorUser.Location = new System.Drawing.Point(965, 341);
            this.lblErrorUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorUser.Name = "lblErrorUser";
            this.lblErrorUser.Size = new System.Drawing.Size(0, 17);
            this.lblErrorUser.TabIndex = 72;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(1017, 617);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 62);
            this.button2.TabIndex = 71;
            this.button2.Text = "Inapoi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(673, 545);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 62);
            this.button1.TabIndex = 70;
            this.button1.Text = "Inregistrare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cboFunctie
            // 
            this.cboFunctie.FormattingEnabled = true;
            this.cboFunctie.Items.AddRange(new object[] {
            "Personal Hotel",
            "Personal Restaurant",
            "ResponsabilEvenimente"});
            this.cboFunctie.Location = new System.Drawing.Point(619, 178);
            this.cboFunctie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFunctie.Name = "cboFunctie";
            this.cboFunctie.Size = new System.Drawing.Size(255, 24);
            this.cboFunctie.TabIndex = 64;
            this.cboFunctie.SelectedIndexChanged += new System.EventHandler(this.cboFunctie_SelectedIndexChanged_1);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(619, 302);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(255, 22);
            this.txtAdresa.TabIndex = 67;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(619, 382);
            this.txtParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(255, 22);
            this.txtParola.TabIndex = 69;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(619, 260);
            this.TxtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(255, 22);
            this.TxtTelefon.TabIndex = 66;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(619, 222);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 22);
            this.txtEmail.TabIndex = 65;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(619, 341);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(255, 22);
            this.txtUser.TabIndex = 68;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(619, 138);
            this.txtPrenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(255, 22);
            this.txtPrenume.TabIndex = 63;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(619, 97);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(255, 22);
            this.txtNume.TabIndex = 62;
            // 
            // lblFunctie
            // 
            this.lblFunctie.AutoSize = true;
            this.lblFunctie.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblFunctie.Location = new System.Drawing.Point(457, 165);
            this.lblFunctie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFunctie.Name = "lblFunctie";
            this.lblFunctie.Size = new System.Drawing.Size(115, 41);
            this.lblFunctie.TabIndex = 61;
            this.lblFunctie.Text = "Functia";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblAdresa.Location = new System.Drawing.Point(457, 287);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(101, 41);
            this.lblAdresa.TabIndex = 60;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblParola.Location = new System.Drawing.Point(457, 368);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(96, 41);
            this.lblParola.TabIndex = 59;
            this.lblParola.Text = "Parola";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblTelefon.Location = new System.Drawing.Point(457, 246);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(108, 41);
            this.lblTelefon.TabIndex = 58;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblEmail.Location = new System.Drawing.Point(459, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(90, 41);
            this.lblEmail.TabIndex = 57;
            this.lblEmail.Text = "Email";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblUser.Location = new System.Drawing.Point(457, 327);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 41);
            this.lblUser.TabIndex = 56;
            this.lblUser.Text = "User";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblPrenume.Location = new System.Drawing.Point(457, 124);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(123, 41);
            this.lblPrenume.TabIndex = 55;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblName.Location = new System.Drawing.Point(457, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 41);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Nume";
            // 
            // LblCaracter
            // 
            this.LblCaracter.AutoSize = true;
            this.LblCaracter.Location = new System.Drawing.Point(655, 489);
            this.LblCaracter.Name = "LblCaracter";
            this.LblCaracter.Size = new System.Drawing.Size(185, 17);
            this.LblCaracter.TabIndex = 53;
            this.LblCaracter.Text = "cel putin un caracter special";
            // 
            // lblCifra
            // 
            this.lblCifra.AutoSize = true;
            this.lblCifra.Location = new System.Drawing.Point(655, 473);
            this.lblCifra.Name = "lblCifra";
            this.lblCifra.Size = new System.Drawing.Size(104, 17);
            this.lblCifra.TabIndex = 52;
            this.lblCifra.Text = "cel putin o cifra";
            // 
            // lblLiteraMica
            // 
            this.lblLiteraMica.AutoSize = true;
            this.lblLiteraMica.Location = new System.Drawing.Point(655, 457);
            this.lblLiteraMica.Name = "lblLiteraMica";
            this.lblLiteraMica.Size = new System.Drawing.Size(141, 17);
            this.lblLiteraMica.TabIndex = 51;
            this.lblLiteraMica.Text = "cel putin o litera mica";
            // 
            // lblLiteraMare
            // 
            this.lblLiteraMare.AutoSize = true;
            this.lblLiteraMare.Location = new System.Drawing.Point(655, 441);
            this.lblLiteraMare.Name = "lblLiteraMare";
            this.lblLiteraMare.Size = new System.Drawing.Size(144, 17);
            this.lblLiteraMare.TabIndex = 50;
            this.lblLiteraMare.Text = "cel putin o litera mare";
            // 
            // lblDimensiune
            // 
            this.lblDimensiune.AutoSize = true;
            this.lblDimensiune.Location = new System.Drawing.Point(655, 425);
            this.lblDimensiune.Name = "lblDimensiune";
            this.lblDimensiune.Size = new System.Drawing.Size(109, 17);
            this.lblDimensiune.TabIndex = 49;
            this.lblDimensiune.Text = "8 - 15 caractere";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // MeniuAdministrator_AdaugarePersoanl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1243, 693);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnStergerePersonal);
            this.Controls.Add(this.lblErrorNume);
            this.Controls.Add(this.lblErrorParola);
            this.Controls.Add(this.lblErrorUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboFunctie);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblFunctie);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.LblCaracter);
            this.Controls.Add(this.lblCifra);
            this.Controls.Add(this.lblLiteraMica);
            this.Controls.Add(this.lblLiteraMare);
            this.Controls.Add(this.lblDimensiune);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MeniuAdministrator_AdaugarePersoanl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuAdministrator_AdaugarePersoanl";
            this.Load += new System.EventHandler(this.MeniuAdministrator_AdaugarePersoanl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnStergerePersonal;
        private System.Windows.Forms.Label lblErrorNume;
        private System.Windows.Forms.Label lblErrorParola;
        private System.Windows.Forms.Label lblErrorUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboFunctie;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblFunctie;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label LblCaracter;
        private System.Windows.Forms.Label lblCifra;
        private System.Windows.Forms.Label lblLiteraMica;
        private System.Windows.Forms.Label lblLiteraMare;
        private System.Windows.Forms.Label lblDimensiune;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}