namespace TugasAkhir
{
    partial class FormFilterDenda
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
            this.viewpembayaranBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tugas_akhir_perpustakaanDataSet1 = new TugasAkhir.tugas_akhir_perpustakaanDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewpembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_pembayaranTableAdapter = new TugasAkhir.tugas_akhir_perpustakaanDataSet1TableAdapters.view_pembayaranTableAdapter();
            this.view_pembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tugasakhirperpustakaanDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewpembayaranBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.viewpembayaranBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugas_akhir_perpustakaanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewpembayaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_pembayaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasakhirperpustakaanDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewpembayaranBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // viewpembayaranBindingSource1
            // 
            this.viewpembayaranBindingSource1.DataMember = "view_pembayaran";
            this.viewpembayaranBindingSource1.DataSource = this.tugas_akhir_perpustakaanDataSet1;
            // 
            // tugas_akhir_perpustakaanDataSet1
            // 
            this.tugas_akhir_perpustakaanDataSet1.DataSetName = "tugas_akhir_perpustakaanDataSet1";
            this.tugas_akhir_perpustakaanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewpembayaranBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TugasAkhir.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1145, 622);
            this.reportViewer1.TabIndex = 3;
            // 
            // viewpembayaranBindingSource
            // 
            this.viewpembayaranBindingSource.DataMember = "view_pembayaran";
            this.viewpembayaranBindingSource.DataSource = this.tugas_akhir_perpustakaanDataSet1;
            // 
            // view_pembayaranTableAdapter
            // 
            this.view_pembayaranTableAdapter.ClearBeforeFill = true;
            // 
            // view_pembayaranBindingSource
            // 
            this.view_pembayaranBindingSource.DataMember = "view_pembayaran";
            this.view_pembayaranBindingSource.DataSource = this.tugas_akhir_perpustakaanDataSet1;
            // 
            // tugasakhirperpustakaanDataSet1BindingSource
            // 
            this.tugasakhirperpustakaanDataSet1BindingSource.DataSource = this.tugas_akhir_perpustakaanDataSet1;
            this.tugasakhirperpustakaanDataSet1BindingSource.Position = 0;
            // 
            // viewpembayaranBindingSource2
            // 
            this.viewpembayaranBindingSource2.DataMember = "view_pembayaran";
            this.viewpembayaranBindingSource2.DataSource = this.tugasakhirperpustakaanDataSet1BindingSource;
            // 
            // FormFilterDenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 622);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormFilterDenda";
            this.Text = "FormFilterDenda";
            this.Load += new System.EventHandler(this.FormFilterDenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewpembayaranBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugas_akhir_perpustakaanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewpembayaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_pembayaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasakhirperpustakaanDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewpembayaranBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tugas_akhir_perpustakaanDataSet1 tugas_akhir_perpustakaanDataSet1;
        private System.Windows.Forms.BindingSource viewpembayaranBindingSource;
        private tugas_akhir_perpustakaanDataSet1TableAdapters.view_pembayaranTableAdapter view_pembayaranTableAdapter;
        private System.Windows.Forms.BindingSource viewpembayaranBindingSource1;
        private System.Windows.Forms.BindingSource view_pembayaranBindingSource;
        private System.Windows.Forms.BindingSource tugasakhirperpustakaanDataSet1BindingSource;
        private System.Windows.Forms.BindingSource viewpembayaranBindingSource2;
    }
}