namespace E6_Testare_DesktopApp
{
    partial class MeniuPersonalHotelVerificaDisponibilitatea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuPersonalHotelVerificaDisponibilitatea));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.queryToolStrip = new System.Windows.Forms.ToolStrip();
            this.queryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nrCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPaturiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaliiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretCameraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camereBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCamere = new E6_Testare_DesktopApp.DataSetCamere();
            this.camereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camereTableAdapter = new E6_Testare_DesktopApp.DataSetCamereTableAdapters.CamereTableAdapter();
            this.lblBuna = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.queryToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCamere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(497, 351);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 76);
            this.button1.TabIndex = 37;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrCameraDataGridViewTextBoxColumn,
            this.nrPaturiDataGridViewTextBoxColumn,
            this.detaliiDataGridViewTextBoxColumn,
            this.pretCameraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.camereBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(137, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(585, 134);
            this.dataGridView1.TabIndex = 38;
            // 
            // queryToolStrip
            // 
            this.queryToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.queryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripButton});
            this.queryToolStrip.Location = new System.Drawing.Point(0, 0);
            this.queryToolStrip.Name = "queryToolStrip";
            this.queryToolStrip.Size = new System.Drawing.Size(800, 27);
            this.queryToolStrip.TabIndex = 39;
            this.queryToolStrip.Text = "queryToolStrip";
            // 
            // queryToolStripButton
            // 
            this.queryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.queryToolStripButton.Name = "queryToolStripButton";
            this.queryToolStripButton.Size = new System.Drawing.Size(52, 24);
            this.queryToolStripButton.Text = "Query";
            this.queryToolStripButton.Click += new System.EventHandler(this.queryToolStripButton_Click);
            // 
            // nrCameraDataGridViewTextBoxColumn
            // 
            this.nrCameraDataGridViewTextBoxColumn.DataPropertyName = "NrCamera";
            this.nrCameraDataGridViewTextBoxColumn.HeaderText = "NrCamera";
            this.nrCameraDataGridViewTextBoxColumn.Name = "nrCameraDataGridViewTextBoxColumn";
            // 
            // nrPaturiDataGridViewTextBoxColumn
            // 
            this.nrPaturiDataGridViewTextBoxColumn.DataPropertyName = "NrPaturi";
            this.nrPaturiDataGridViewTextBoxColumn.HeaderText = "NrPaturi";
            this.nrPaturiDataGridViewTextBoxColumn.Name = "nrPaturiDataGridViewTextBoxColumn";
            // 
            // detaliiDataGridViewTextBoxColumn
            // 
            this.detaliiDataGridViewTextBoxColumn.DataPropertyName = "Detalii";
            this.detaliiDataGridViewTextBoxColumn.HeaderText = "Detalii";
            this.detaliiDataGridViewTextBoxColumn.Name = "detaliiDataGridViewTextBoxColumn";
            // 
            // pretCameraDataGridViewTextBoxColumn
            // 
            this.pretCameraDataGridViewTextBoxColumn.DataPropertyName = "PretCamera";
            this.pretCameraDataGridViewTextBoxColumn.HeaderText = "PretCamera";
            this.pretCameraDataGridViewTextBoxColumn.Name = "pretCameraDataGridViewTextBoxColumn";
            // 
            // camereBindingSource1
            // 
            this.camereBindingSource1.DataMember = "Camere";
            this.camereBindingSource1.DataSource = this.dataSetCamere;
            // 
            // dataSetCamere
            // 
            this.dataSetCamere.DataSetName = "DataSetCamere";
            this.dataSetCamere.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // camereBindingSource
            // 
            this.camereBindingSource.DataMember = "Camere";
            this.camereBindingSource.DataSource = this.dataSetCamere;
            // 
            // camereTableAdapter
            // 
            this.camereTableAdapter.ClearBeforeFill = true;
            // 
            // lblBuna
            // 
            this.lblBuna.AutoSize = true;
            this.lblBuna.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.lblBuna.Location = new System.Drawing.Point(44, 27);
            this.lblBuna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuna.Name = "lblBuna";
            this.lblBuna.Size = new System.Drawing.Size(727, 168);
            this.lblBuna.TabIndex = 40;
            this.lblBuna.Text = resources.GetString("lblBuna.Text");
            this.lblBuna.Click += new System.EventHandler(this.lblBuna_Click);
            // 
            // MeniuPersonalHotelVerificaDisponibilitatea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBuna);
            this.Controls.Add(this.queryToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "MeniuPersonalHotelVerificaDisponibilitatea";
            this.Text = "MeniuPersonalHotelVerificaDisponibilitatea";
            this.Load += new System.EventHandler(this.MeniuPersonalHotelVerificaDisponibilitatea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.queryToolStrip.ResumeLayout(false);
            this.queryToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCamere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camereBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetCamere dataSetCamere;
        private System.Windows.Forms.BindingSource camereBindingSource;
        private DataSetCamereTableAdapters.CamereTableAdapter camereTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPaturiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detaliiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretCameraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource camereBindingSource1;
        private System.Windows.Forms.ToolStrip queryToolStrip;
        private System.Windows.Forms.ToolStripButton queryToolStripButton;
        private System.Windows.Forms.Label lblBuna;
    }
}