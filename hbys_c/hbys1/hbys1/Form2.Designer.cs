namespace hbys1
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.yatan_hastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet2 = new hbys1.Database1DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database1DataSet = new hbys1.Database1DataSet();
            this.hasta_kayit_tabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hasta_kayit_tabloTableAdapter = new hbys1.Database1DataSetTableAdapters.hasta_kayit_tabloTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.yatan_hastaTableAdapter = new hbys1.Database1DataSet2TableAdapters.yatan_hastaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.yatan_hastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasta_kayit_tabloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // yatan_hastaBindingSource
            // 
            this.yatan_hastaBindingSource.DataMember = "yatan_hasta";
            this.yatan_hastaBindingSource.DataSource = this.Database1DataSet2;
            // 
            // Database1DataSet2
            // 
            this.Database1DataSet2.DataSetName = "Database1DataSet2";
            this.Database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.LightSteelBlue;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.yatan_hastaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "hbys1.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1016, 332);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hasta_kayit_tabloBindingSource
            // 
            this.hasta_kayit_tabloBindingSource.DataMember = "hasta_kayit_tablo";
            this.hasta_kayit_tabloBindingSource.DataSource = this.Database1DataSet;
            // 
            // hasta_kayit_tabloTableAdapter
            // 
            this.hasta_kayit_tabloTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(504, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Raporla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yatan_hastaTableAdapter
            // 
            this.yatan_hastaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(640, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Geri git";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(849, 40);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(8, 11);
            this.reportViewer2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yatan_hastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasta_kayit_tabloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hasta_kayit_tabloBindingSource;
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.hasta_kayit_tabloTableAdapter hasta_kayit_tabloTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource yatan_hastaBindingSource;
        private Database1DataSet2 Database1DataSet2;
        private Database1DataSet2TableAdapters.yatan_hastaTableAdapter yatan_hastaTableAdapter;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}