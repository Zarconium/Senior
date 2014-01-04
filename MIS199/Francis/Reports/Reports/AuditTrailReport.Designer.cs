namespace Reports
{
    partial class AuditTrailReport
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
            this.user_history_tBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AuditTrailRepordDataSet = new Reports.AuditTrailRepordDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.user_history_tTableAdapter = new Reports.AuditTrailRepordDataSetTableAdapters.user_history_tTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.user_history_tBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuditTrailRepordDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // user_history_tBindingSource
            // 
            this.user_history_tBindingSource.DataMember = "user_history_t";
            this.user_history_tBindingSource.DataSource = this.AuditTrailRepordDataSet;
            // 
            // AuditTrailRepordDataSet
            // 
            this.AuditTrailRepordDataSet.DataSetName = "AuditTrailRepordDataSet";
            this.AuditTrailRepordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AuditTrailReportDataSet";
            reportDataSource1.Value = this.user_history_tBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reports.AuditTrailReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(651, 309);
            this.reportViewer1.TabIndex = 0;
            // 
            // user_history_tTableAdapter
            // 
            this.user_history_tTableAdapter.ClearBeforeFill = true;
            // 
            // AuditTrailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 309);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AuditTrailReport";
            this.Text = "Audit Trail Report ";
            this.Load += new System.EventHandler(this.AuditTrailReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_history_tBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuditTrailRepordDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource user_history_tBindingSource;
        private AuditTrailRepordDataSet AuditTrailRepordDataSet;
        private AuditTrailRepordDataSetTableAdapters.user_history_tTableAdapter user_history_tTableAdapter;
    }
}