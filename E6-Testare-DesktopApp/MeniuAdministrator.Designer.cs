﻿namespace E6_Testare_DesktopApp
{
    partial class MeniuAdministrator
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
            this.btnRapoarte = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblBuna = new System.Windows.Forms.Label();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRapoarte
            // 
            this.btnRapoarte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRapoarte.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnRapoarte.Location = new System.Drawing.Point(57, 150);
            this.btnRapoarte.Margin = new System.Windows.Forms.Padding(4);
            this.btnRapoarte.Name = "btnRapoarte";
            this.btnRapoarte.Size = new System.Drawing.Size(267, 57);
            this.btnRapoarte.TabIndex = 16;
            this.btnRapoarte.Text = "Rapoarte";
            this.btnRapoarte.UseVisualStyleBackColor = false;
            this.btnRapoarte.Click += new System.EventHandler(this.btnRapoarte_Click);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.lblNume.Location = new System.Drawing.Point(846, 56);
            this.lblNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 22);
            this.lblNume.TabIndex = 18;
            this.lblNume.Text = "label2";
            // 
            // lblBuna
            // 
            this.lblBuna.AutoSize = true;
            this.lblBuna.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.lblBuna.Location = new System.Drawing.Point(774, 29);
            this.lblBuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuna.Name = "lblBuna";
            this.lblBuna.Size = new System.Drawing.Size(55, 22);
            this.lblBuna.TabIndex = 17;
            this.lblBuna.Text = "Buna, ";
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCont.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.btnCont.Location = new System.Drawing.Point(776, 83);
            this.btnCont.Margin = new System.Windows.Forms.Padding(5);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(121, 34);
            this.btnCont.TabIndex = 19;
            this.btnCont.Text = "Cont";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnInapoi.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnInapoi.Location = new System.Drawing.Point(675, 489);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(243, 60);
            this.btnInapoi.TabIndex = 20;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(25, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 57);
            this.button1.TabIndex = 22;
            this.button1.Text = "Creare cont personal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MeniuAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(932, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblBuna);
            this.Controls.Add(this.btnRapoarte);
            this.Name = "MeniuAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniuAdministrator";
            this.Load += new System.EventHandler(this.MeniuAdministrator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRapoarte;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblBuna;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Button button1;
    }
}