namespace TugasAkhir
{
    partial class FormBuku1
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tugas_akhir_perpustakaanDataSet1 = new TugasAkhir.tugas_akhir_perpustakaanDataSet1();
            this.bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bukuTableAdapter = new TugasAkhir.tugas_akhir_perpustakaanDataSet1TableAdapters.bukuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tugas_akhir_perpustakaanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bukuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TugasAkhir.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tugas_akhir_perpustakaanDataSet1
            // 
            this.tugas_akhir_perpustakaanDataSet1.DataSetName = "tugas_akhir_perpustakaanDataSet1";
            this.tugas_akhir_perpustakaanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bukuBindingSource
            // 
            this.bukuBindingSource.DataMember = "buku";
            this.bukuBindingSource.DataSource = this.tugas_akhir_perpustakaanDataSet1;
            // 
            // bukuTableAdapter
            // 
            this.bukuTableAdapter.ClearBeforeFill = true;
            // 
            // FormBuku1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBuku1";
            this.Text = "FormBuku1";
            this.Load += new System.EventHandler(this.FormBuku1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tugas_akhir_perpustakaanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tugas_akhir_perpustakaanDataSet1 tugas_akhir_perpustakaanDataSet1;
        private System.Windows.Forms.BindingSource bukuBindingSource;
        private tugas_akhir_perpustakaanDataSet1TableAdapters.bukuTableAdapter bukuTableAdapter;
    }
}