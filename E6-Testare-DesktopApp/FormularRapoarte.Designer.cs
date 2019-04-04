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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.QRzervariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TestareBDDataSet4 = new E6_Testare_DesktopApp.TestareBDDataSet4();
            this.RezervariRestaurantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QRezervariEvenimenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TestareBDDataSet5 = new E6_Testare_DesktopApp.TestareBDDataSet5();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEvenimente = new System.Windows.Forms.Button();
            this.btnMeniuriSucces = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QRzervariTableAdapter = new E6_Testare_DesktopApp.TestareBDDataSet4TableAdapters.QRzervariTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RezervariRestaurantTableAdapter = new E6_Testare_DesktopApp.TestareBDDataSet4TableAdapters.RezervariRestaurantTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QRezervariEvenimenteTableAdapter = new E6_Testare_DesktopApp.TestareBDDataSet5TableAdapters.QRezervariEvenimenteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QRzervariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestareBDDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervariRestaurantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRezervariEvenimenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestareBDDataSet5)).BeginInit();
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
            // RezervariRestaurantBindingSource
            // 
            this.RezervariRestaurantBindingSource.DataMember = "RezervariRestaurant";
            this.RezervariRestaurantBindingSource.DataSource = this.TestareBDDataSet4;
            // 
            // QRezervariEvenimenteBindingSource
            // 
            this.QRezervariEvenimenteBindingSource.DataMember = "QRezervariEvenimente";
            this.QRezervariEvenimenteBindingSource.DataSource = this.TestareBDDataSet5;
            // 
            // TestareBDDataSet5
            // 
            this.TestareBDDataSet5.DataSetName = "TestareBDDataSet5";
            this.TestareBDDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(33, 67);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 82);
            this.button4.TabIndex = 14;
            this.button4.Text = "Raport rezervari hotel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEvenimente
            // 
            this.btnEvenimente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEvenimente.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvenimente.Location = new System.Drawing.Point(33, 382);
            this.btnEvenimente.Margin = new System.Windows.Forms.Padding(5);
            this.btnEvenimente.Name = "btnEvenimente";
            this.btnEvenimente.Size = new System.Drawing.Size(253, 81);
            this.btnEvenimente.TabIndex = 11;
            this.btnEvenimente.Text = "Rapoarte evenimente";
            this.btnEvenimente.UseVisualStyleBackColor = false;
            this.btnEvenimente.Click += new System.EventHandler(this.btnEvenimente_Click);
            // 
            // btnMeniuriSucces
            // 
            this.btnMeniuriSucces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMeniuriSucces.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeniuriSucces.Location = new System.Drawing.Point(33, 227);
            this.btnMeniuriSucces.Margin = new System.Windows.Forms.Padding(5);
            this.btnMeniuriSucces.Name = "btnMeniuriSucces";
            this.btnMeniuriSucces.Size = new System.Drawing.Size(253, 78);
            this.btnMeniuriSucces.TabIndex = 10;
            this.btnMeniuriSucces.Text = "Raport rezervari restaurant";
            this.btnMeniuriSucces.UseVisualStyleBackColor = false;
            this.btnMeniuriSucces.Click += new System.EventHandler(this.btnMeniuriSucces_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.button5.Location = new System.Drawing.Point(1008, 602);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 59);
            this.button5.TabIndex = 18;
            this.button5.Text = "Inapoi";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 97;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.QRzervariBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "E6_Testare_DesktopApp.Rezervari.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(316, 16);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(857, 547);
            this.reportViewer1.TabIndex = 19;
            // 
            // QRzervariTableAdapter
            // 
            this.QRzervariTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.DocumentMapWidth = 97;
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.RezervariRestaurantBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "E6_Testare_DesktopApp.Rezervari restaurant.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(316, 16);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(857, 547);
            this.reportViewer2.TabIndex = 20;
            // 
            // RezervariRestaurantTableAdapter
            // 
            this.RezervariRestaurantTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.DocumentMapWidth = 97;
            reportDataSource9.Name = "DataSet1";
            reportDataSource9.Value = this.QRezervariEvenimenteBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "E6_Testare_DesktopApp.Rezervari evenimente.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(316, 16);
            this.reportViewer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(857, 547);
            this.reportViewer3.TabIndex = 21;
            // 
            // QRezervariEvenimenteTableAdapter
            // 
            this.QRezervariEvenimenteTableAdapter.ClearBeforeFill = true;
            // 
            // FormularRapoarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1243, 693);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEvenimente);
            this.Controls.Add(this.btnMeniuriSucces);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularRapoarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularRapoarte";
            this.Load += new System.EventHandler(this.FormularRapoarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRzervariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestareBDDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezervariRestaurantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRezervariEvenimenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestareBDDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEvenimente;
        private System.Windows.Forms.Button btnMeniuriSucces;
        private System.Windows.Forms.Button button5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource QRzervariBindingSource;
        private TestareBDDataSet4 TestareBDDataSet4;
        private TestareBDDataSet4TableAdapters.QRzervariTableAdapter QRzervariTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource RezervariRestaurantBindingSource;
        private TestareBDDataSet4TableAdapters.RezervariRestaurantTableAdapter RezervariRestaurantTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource QRezervariEvenimenteBindingSource;
        private TestareBDDataSet5 TestareBDDataSet5;
        private TestareBDDataSet5TableAdapters.QRezervariEvenimenteTableAdapter QRezervariEvenimenteTableAdapter;
    }
}