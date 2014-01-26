namespace Reports
{
    partial class ReportOptionB
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
            this.OptionBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OptionaABDataSet = new Reports.OptionaABDataSet();
            this.OptionABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OptionATableAdapter = new Reports.OptionaABDataSetTableAdapters.OptionATableAdapter();
            this.OptionBTableAdapter = new Reports.OptionaABDataSetTableAdapters.OptionBTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datetimefromB = new System.Windows.Forms.DateTimePicker();
            this.datetimetoB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbAuditArea = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OptionBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionaABDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionABindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionBBindingSource
            // 
            this.OptionBBindingSource.DataMember = "OptionB";
            this.OptionBBindingSource.DataSource = this.OptionaABDataSet;
            // 
            // OptionaABDataSet
            // 
            this.OptionaABDataSet.DataSetName = "OptionaABDataSet";
            this.OptionaABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OptionABindingSource
            // 
            this.OptionABindingSource.DataMember = "OptionA";
            this.OptionABindingSource.DataSource = this.OptionaABDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "NameReportOptionB";
            reportDataSource1.Value = this.OptionBBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reports.ReportOptionB.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1253, 788);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // OptionATableAdapter
            // 
            this.OptionATableAdapter.ClearBeforeFill = true;
            // 
            // OptionBTableAdapter
            // 
            this.OptionBTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datetimefromB);
            this.groupBox3.Controls.Add(this.datetimetoB);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(757, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 96);
            this.groupBox3.TabIndex = 121;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Engagement Date ";
            // 
            // datetimefromB
            // 
            this.datetimefromB.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimefromB.Location = new System.Drawing.Point(111, 22);
            this.datetimefromB.Name = "datetimefromB";
            this.datetimefromB.Size = new System.Drawing.Size(210, 23);
            this.datetimefromB.TabIndex = 14;
            // 
            // datetimetoB
            // 
            this.datetimetoB.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimetoB.Location = new System.Drawing.Point(111, 58);
            this.datetimetoB.Name = "datetimetoB";
            this.datetimetoB.Size = new System.Drawing.Size(210, 23);
            this.datetimetoB.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 104;
            this.label9.Text = "To:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 103;
            this.label10.Text = "From:";
            // 
            // cbAuditArea
            // 
            this.cbAuditArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuditArea.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuditArea.FormattingEnabled = true;
            this.cbAuditArea.Items.AddRange(new object[] {
            "All"});
            this.cbAuditArea.Location = new System.Drawing.Point(167, 15);
            this.cbAuditArea.Name = "cbAuditArea";
            this.cbAuditArea.Size = new System.Drawing.Size(251, 23);
            this.cbAuditArea.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 120;
            this.label5.Text = "Audit Area:";
            // 
            // ReportOptionB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 905);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbAuditArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportOptionB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportOptionB";
            this.Load += new System.EventHandler(this.ReportOptionB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OptionBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionaABDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionABindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OptionABindingSource;
        private OptionaABDataSet OptionaABDataSet;
        private OptionaABDataSetTableAdapters.OptionATableAdapter OptionATableAdapter;
        private System.Windows.Forms.BindingSource OptionBBindingSource;
        private OptionaABDataSetTableAdapters.OptionBTableAdapter OptionBTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker datetimefromB;
        private System.Windows.Forms.DateTimePicker datetimetoB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbAuditArea;
        private System.Windows.Forms.Label label5;
    }
}