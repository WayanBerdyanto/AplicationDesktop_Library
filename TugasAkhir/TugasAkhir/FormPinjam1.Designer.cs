namespace TugasAkhir
{
    partial class FormPinjam1
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
            this.tugasakhirperpustakaanDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewmasterPinjamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_masterPinjamTableAdapter = new TugasAkhir.tugas_akhir_perpustakaanDataSet1TableAdapters.view_masterPinjamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tugas_akhir_perpustakaanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasakhirperpustakaanDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmasterPinjamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewmasterPinjamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TugasAkhir.Report2.rdlc";
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
            // tugasakhirperpustakaanDataSet1BindingSource
            // 
            this.tugasakhirperpustakaanDataSet1BindingSource.DataSource = this.tugas_akhir_perpustakaanDataSet1;
            this.tugasakhirperpustakaanDataSet1BindingSource.Position = 0;
            // 
            // viewmasterPinjamBindingSource
            // 
            this.viewmasterPinjamBindingSource.DataMember = "view_masterPinjam";
            this.viewmasterPinjamBindingSource.DataSource = this.tugas_akhir_perpustakaanDataSet1;
            // 
            // view_masterPinjamTableAdapter
            // 
            this.view_masterPinjamTableAdapter.ClearBeforeFill = true;
            // 
            // FormPinjam1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPinjam1";
            this.Text = "FormPinjam1";
            this.Load += new System.EventHandler(this.FormPinjam1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tugas_akhir_perpustakaanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasakhirperpustakaanDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmasterPinjamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tugas_akhir_perpustakaanDataSet1 tugas_akhir_perpustakaanDataSet1;
        private System.Windows.Forms.BindingSource tugasakhirperpustakaanDataSet1BindingSource;
        private System.Windows.Forms.BindingSource viewmasterPinjamBindingSource;
        private tugas_akhir_perpustakaanDataSet1TableAdapters.view_masterPinjamTableAdapter view_masterPinjamTableAdapter;
    }
}