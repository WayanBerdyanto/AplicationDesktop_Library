namespace TugasAkhir
{
    partial class LaporanPengembalian
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
            this.vievdetailKembaliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viev_detailKembaliTableAdapter = new TugasAkhir.tugas_akhir_perpustakaanDataSet1TableAdapters.viev_detailKembaliTableAdapter();
            this.viewmasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_masterTableAdapter = new TugasAkhir.tugas_akhir_perpustakaanDataSet1TableAdapters.view_masterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tugas_akhir_perpustakaanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vievdetailKembaliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.viewmasterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TugasAkhir.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1105, 620);
            this.reportViewer1.TabIndex = 0;
            // 
            // tugas_akhir_perpustakaanDataSet1
            // 
            this.tugas_akhir_perpustakaanDataSet1.DataSetName = "tugas_akhir_perpustakaanDataSet1";
            this.tugas_akhir_perpustakaanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vievdetailKembaliBindingSource
            // 
            this.vievdetailKembaliBindingSource.DataMember = "viev_detailKembali";
            this.vievdetailKembaliBindingSource.DataSource = this.tugas_akhir_perpustakaanDataSet1;
            // 
            // viev_detailKembaliTableAdapter
            // 
            this.viev_detailKembaliTableAdapter.ClearBeforeFill = true;
            // 
            // viewmasterBindingSource
            // 
            this.viewmasterBindingSource.DataMember = "view_master";
            this.viewmasterBindingSource.DataSource = this.tugas_akhir_perpustakaanDataSet1;
            // 
            // view_masterTableAdapter
            // 
            this.view_masterTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 620);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LaporanPengembalian";
            this.Text = "LaporanPengembalian";
            this.Load += new System.EventHandler(this.LaporanPengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tugas_akhir_perpustakaanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vievdetailKembaliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewmasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tugas_akhir_perpustakaanDataSet1 tugas_akhir_perpustakaanDataSet1;
        private System.Windows.Forms.BindingSource vievdetailKembaliBindingSource;
        private tugas_akhir_perpustakaanDataSet1TableAdapters.viev_detailKembaliTableAdapter viev_detailKembaliTableAdapter;
        private System.Windows.Forms.BindingSource viewmasterBindingSource;
        private tugas_akhir_perpustakaanDataSet1TableAdapters.view_masterTableAdapter view_masterTableAdapter;
    }
}