namespace E6_Testare_DesktopApp
{
    partial class FormularRapoarte
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.QRzervariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TestareBDDataSet4 = new E6_Testare_DesktopApp.TestareBDDataSet4();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEvenimente = new System.Windows.Forms.Button();
            this.btnMeniuriSucces = new System.Windows.Forms.Button();
            this.btnIncasariCamera = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QRzervariTableAdapter = new E6_Testare_DesktopApp.TestareBDDataSet4TableAdapters.QRzervariTableAdapter();
            this.RezervariRestaurantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RezervariRestaurantTableAdapter = new E6_Testare_DesktopApp.TestareBDDataSet4TableAdapters.RezervariRestaurantTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QRzervariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestareBDDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervariRestaurantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // QRzervariBindingSource
            // 
            this.QRzervariBindingSource.DataMember = "QRzervari";
            this.QRzervariBindingSource.DataSource = this.TestareBDDataSet4;
            // 
            // TestareBDDataSet4
            // 
            this.TestareBDDataSet4.DataSetName = "TestareBDDataSet4";
            this.TestareBDDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(25, 13);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 67);
            this.button4.TabIndex = 14;
            this.button4.Text = "Raport rezervari hotel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(25, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 67);
            this.button2.TabIndex = 13;
            this.button2.Text = "Grafic vanzari pe perioade";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "Rapoarte clienti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEvenimente
            // 
            this.btnEvenimente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEvenimente.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvenimente.Location = new System.Drawing.Point(25, 159);
            this.btnEvenimente.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvenimente.Name = "btnEvenimente";
            this.btnEvenimente.Size = new System.Drawing.Size(190, 66);
            this.btnEvenimente.TabIndex = 11;
            this.btnEvenimente.Text = "Rapoarte rezervari restaurant";
            this.btnEvenimente.UseVisualStyleBackColor = false;
            this.btnEvenimente.Click += new System.EventHandler(this.btnEvenimente_Click);
            // 
            // btnMeniuriSucces
            // 
            this.btnMeniuriSucces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMeniuriSucces.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeniuriSucces.Location = new System.Drawing.Point(25, 88);
            this.btnMeniuriSucces.Margin = new System.Windows.Forms.Padding(4);
            this.btnMeniuriSucces.Name = "btnMeniuriSucces";
            this.btnMeniuriSucces.Size = new System.Drawing.Size(190, 63);
            this.btnMeniuriSucces.TabIndex = 10;
            this.btnMeniuriSucces.Text = "Raport solicitari locatii";
            this.btnMeniuriSucces.UseVisualStyleBackColor = false;
            this.btnMeniuriSucces.Click += new System.EventHandler(this.btnMeniuriSucces_Click);
            // 
            // btnIncasariCamera
            // 
            this.btnIncasariCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnIncasariCamera.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncasariCamera.Location = new System.Drawing.Point(25, 306);
            this.btnIncasariCamera.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncasariCamera.Name = "btnIncasariCamera";
            this.btnIncasariCamera.Size = new System.Drawing.Size(190, 65);
            this.btnIncasariCamera.TabIndex = 9;
            this.btnIncasariCamera.Text = "Rapoarte incasari camere";
            this.btnIncasariCamera.UseVisualStyleBackColor = false;
            this.btnIncasariCamera.Click += new System.EventHandler(this.btnIncasariCamera_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.button5.Location = new System.Drawing.Point(756, 489);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 48);
            this.button5.TabIndex = 18;
            this.button5.Text = "Inapoi";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 97;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.QRzervariBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "E6_Testare_DesktopApp.Rezervari.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(237, 13);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(643, 445);
            this.reportViewer1.TabIndex = 19;
            // 
            // QRzervariTableAdapter
            // 
            this.QRzervariTableAdapter.ClearBeforeFill = true;
            // 
            // RezervariRestaurantBindingSource
            // 
            this.RezervariRestaurantBindingSource.DataMember = "RezervariRestaurant";
            this.RezervariRestaurantBindingSource.DataSource = this.TestareBDDataSet4;
            // 
            // RezervariRestaurantTableAdapter
            // 
            this.RezervariRestaurantTableAdapter.ClearBeforeFill = true;
            // 
            // FormularRapoarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(932, 563);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEvenimente);
            this.Controls.Add(this.btnMeniuriSucces);
            this.Controls.Add(this.btnIncasariCamera);
            this.Name = "FormularRapoarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularRapoarte";
            this.Load += new System.EventHandler(this.FormularRapoarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRzervariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestareBDDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervariRestaurantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEvenimente;
        private System.Windows.Forms.Button btnMeniuriSucces;
        private System.Windows.Forms.Button btnIncasariCamera;
        private System.Windows.Forms.Button button5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource QRzervariBindingSource;
        private TestareBDDataSet4 TestareBDDataSet4;
        private TestareBDDataSet4TableAdapters.QRzervariTableAdapter QRzervariTableAdapter;
        private System.Windows.Forms.BindingSource RezervariRestaurantBindingSource;
        private TestareBDDataSet4TableAdapters.RezervariRestaurantTableAdapter RezervariRestaurantTableAdapter;
    }
}