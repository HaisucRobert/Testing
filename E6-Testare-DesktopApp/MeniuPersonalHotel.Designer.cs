namespace E6_Testare_DesktopApp
{
    partial class MeniuPersonalHotel
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSpecificatii = new System.Windows.Forms.RichTextBox();
            this.checkOut = new System.Windows.Forms.DateTimePicker();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.checkIn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCamera = new System.Windows.Forms.Label();
            this.verifica_disponibilitate = new System.Windows.Forms.Button();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 18.25F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(478, 444);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 49);
            this.button2.TabIndex = 37;
            this.button2.Text = "Rezerva";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(921, 536);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 76);
            this.button1.TabIndex = 36;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSpecificatii
            // 
            this.txtSpecificatii.Location = new System.Drawing.Point(179, 241);
            this.txtSpecificatii.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpecificatii.Name = "txtSpecificatii";
            this.txtSpecificatii.Size = new System.Drawing.Size(476, 78);
            this.txtSpecificatii.TabIndex = 34;
            this.txtSpecificatii.Text = "";
            // 
            // checkOut
            // 
            this.checkOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkOut.Location = new System.Drawing.Point(187, 180);
            this.checkOut.Margin = new System.Windows.Forms.Padding(4);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(161, 22);
            this.checkOut.TabIndex = 32;
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(189, 89);
            this.cboCamera.Margin = new System.Windows.Forms.Padding(4);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(160, 24);
            this.cboCamera.TabIndex = 31;
            this.cboCamera.SelectedIndexChanged += new System.EventHandler(this.cboCamera_SelectedIndexChanged);
            // 
            // checkIn
            // 
            this.checkIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkIn.Location = new System.Drawing.Point(187, 129);
            this.checkIn.Margin = new System.Windows.Forms.Padding(4);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(161, 22);
            this.checkIn.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(43, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 34);
            this.label3.TabIndex = 28;
            this.label3.Text = "Specificatii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(43, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 34);
            this.label2.TabIndex = 27;
            this.label2.Text = "Check out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(43, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "Check in";
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic);
            this.lblCamera.Location = new System.Drawing.Point(43, 81);
            this.lblCamera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(89, 34);
            this.lblCamera.TabIndex = 25;
            this.lblCamera.Text = "Camera";
            // 
            // verifica_disponibilitate
            // 
            this.verifica_disponibilitate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.verifica_disponibilitate.Font = new System.Drawing.Font("Monotype Corsiva", 18.25F, System.Drawing.FontStyle.Italic);
            this.verifica_disponibilitate.Location = new System.Drawing.Point(37, 444);
            this.verifica_disponibilitate.Margin = new System.Windows.Forms.Padding(5);
            this.verifica_disponibilitate.Name = "verifica_disponibilitate";
            this.verifica_disponibilitate.Size = new System.Drawing.Size(401, 49);
            this.verifica_disponibilitate.TabIndex = 38;
            this.verifica_disponibilitate.Text = "Verifica disponibilitate";
            this.verifica_disponibilitate.UseVisualStyleBackColor = false;
            this.verifica_disponibilitate.Click += new System.EventHandler(this.verifica_disponibilitate_Click);
            // 
            // txtPret
            // 
            this.txtPret.Enabled = false;
            this.txtPret.Location = new System.Drawing.Point(181, 382);
            this.txtPret.Margin = new System.Windows.Forms.Padding(4);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(132, 22);
            this.txtPret.TabIndex = 40;
            this.txtPret.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(45, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 34);
            this.label4.TabIndex = 39;
            this.label4.Text = "Pret total";
            this.label4.Visible = false;
            // 
            // MeniuPersonalHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1243, 693);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.verifica_disponibilitate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSpecificatii);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCamera);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeniuPersonalHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuPersonalHotel";
            this.Load += new System.EventHandler(this.MeniuPersonalHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtSpecificatii;
        private System.Windows.Forms.DateTimePicker checkOut;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.DateTimePicker checkIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Button verifica_disponibilitate;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label label4;
    }
}