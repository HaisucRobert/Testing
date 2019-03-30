namespace E6_Testare_DesktopApp
{
    partial class MeniuPersonalHotelPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.verifica_disponibilitate = new System.Windows.Forms.Button();
            this.rezerva_o_camera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(419, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 76);
            this.button1.TabIndex = 37;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // verifica_disponibilitate
            // 
            this.verifica_disponibilitate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.verifica_disponibilitate.Font = new System.Drawing.Font("Monotype Corsiva", 18.25F, System.Drawing.FontStyle.Italic);
            this.verifica_disponibilitate.Location = new System.Drawing.Point(77, 142);
            this.verifica_disponibilitate.Margin = new System.Windows.Forms.Padding(5);
            this.verifica_disponibilitate.Name = "verifica_disponibilitate";
            this.verifica_disponibilitate.Size = new System.Drawing.Size(270, 117);
            this.verifica_disponibilitate.TabIndex = 38;
            this.verifica_disponibilitate.Text = "Verifica disponibilitate";
            this.verifica_disponibilitate.UseVisualStyleBackColor = false;
            this.verifica_disponibilitate.Click += new System.EventHandler(this.verifica_disponibilitate_Click);
            // 
            // rezerva_o_camera
            // 
            this.rezerva_o_camera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rezerva_o_camera.Font = new System.Drawing.Font("Monotype Corsiva", 18.25F, System.Drawing.FontStyle.Italic);
            this.rezerva_o_camera.Location = new System.Drawing.Point(419, 142);
            this.rezerva_o_camera.Margin = new System.Windows.Forms.Padding(5);
            this.rezerva_o_camera.Name = "rezerva_o_camera";
            this.rezerva_o_camera.Size = new System.Drawing.Size(270, 117);
            this.rezerva_o_camera.TabIndex = 39;
            this.rezerva_o_camera.Text = "Rezerva o camera";
            this.rezerva_o_camera.UseVisualStyleBackColor = false;
            this.rezerva_o_camera.Click += new System.EventHandler(this.rezerva_o_camera_Click);
            // 
            // MeniuPersonalHotelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rezerva_o_camera);
            this.Controls.Add(this.verifica_disponibilitate);
            this.Controls.Add(this.button1);
            this.Name = "MeniuPersonalHotelPrincipal";
            this.Text = "MeniuPersonalHotelPrincipal";
            this.Load += new System.EventHandler(this.MeniuPersonalHotelPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button verifica_disponibilitate;
        private System.Windows.Forms.Button rezerva_o_camera;
    }
}