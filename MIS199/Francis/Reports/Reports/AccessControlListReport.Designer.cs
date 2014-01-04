namespace Reports
{
    partial class AccessControlListReport
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
            this.audit_user_tBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccessControlListDataSet = new Reports.AccessControlListDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.audit_user_tTableAdapter = new Reports.AccessControlListDataSetTableAdapters.audit_user_tTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.audit_user_tBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessControlListDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // audit_user_tBindingSource
            // 
            this.audit_user_tBindingSource.DataMember = "audit_user_t";
            this.audit_user_tBindingSource.DataSource = this.AccessControlListDataSet;
            // 
            // AccessControlListDataSet
            // 
            this.AccessControlListDataSet.DataSetName = "AccessControlListDataSet";
            this.AccessControlListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AccessControlListDataSet";
            reportDataSource1.Value = this.audit_user_tBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reports.AccessControlList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(681, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // audit_user_tTableAdapter
            // 
            this.audit_user_tTableAdapter.ClearBeforeFill = true;
            // 
            // AccessControlListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 453);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccessControlListReport";
            this.Text = "AccessControlListReport";
            this.Load += new System.EventHandler(this.AccessControlListReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.audit_user_tBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessControlListDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource audit_user_tBindingSource;
        private AccessControlListDataSet AccessControlListDataSet;
        private AccessControlListDataSetTableAdapters.audit_user_tTableAdapter audit_user_tTableAdapter;
    }
}