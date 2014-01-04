namespace Reports
{
    partial class ReportOptionA
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
            this.OptionABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OptionaABDataSet = new Reports.OptionaABDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.generate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.datetimefromA = new System.Windows.Forms.DateTimePicker();
            this.datetimetoA = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAuditableUnit = new System.Windows.Forms.ComboBox();
            this.optionABindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.cbAuditEngagementReferenceNo = new System.Windows.Forms.ComboBox();
            this.optionABindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.optionaABDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbAuditFindingStatus = new System.Windows.Forms.ComboBox();
            this.cbRiskAssessment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAuditGroup = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.optionABindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.optionaABDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OptionATableAdapter = new Reports.OptionaABDataSetTableAdapters.OptionATableAdapter();
            this.optionABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.optionABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.optionABindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.optionABindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OptionABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionaABDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionaABDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionaABDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // OptionABindingSource
            // 
            this.OptionABindingSource.DataMember = "OptionA";
            this.OptionABindingSource.DataSource = this.OptionaABDataSet;
            // 
            // OptionaABDataSet
            // 
            this.OptionaABDataSet.DataSetName = "OptionaABDataSet";
            this.OptionaABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.generate);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.cbAuditableUnit);
            this.groupBox1.Controls.Add(this.cbAuditEngagementReferenceNo);
            this.groupBox1.Controls.Add(this.cbAuditFindingStatus);
            this.groupBox1.Controls.Add(this.cbRiskAssessment);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbAuditGroup);
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1261, 939);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option A";
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.generate.Location = new System.Drawing.Point(885, 144);
            this.generate.Margin = new System.Windows.Forms.Padding(5);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(112, 31);
            this.generate.TabIndex = 131;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clear.Location = new System.Drawing.Point(1007, 144);
            this.clear.Margin = new System.Windows.Forms.Padding(5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(112, 31);
            this.clear.TabIndex = 132;
            this.clear.Text = " Clear";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancel.Location = new System.Drawing.Point(1129, 144);
            this.cancel.Margin = new System.Windows.Forms.Padding(5);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 31);
            this.cancel.TabIndex = 133;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.datetimefromA);
            this.groupBox5.Controls.Add(this.datetimetoA);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(565, 82);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(312, 96);
            this.groupBox5.TabIndex = 130;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Engagement Date ";
            // 
            // datetimefromA
            // 
            this.datetimefromA.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimefromA.Location = new System.Drawing.Point(81, 26);
            this.datetimefromA.Name = "datetimefromA";
            this.datetimefromA.Size = new System.Drawing.Size(210, 23);
            this.datetimefromA.TabIndex = 8;
            // 
            // datetimetoA
            // 
            this.datetimetoA.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimetoA.Location = new System.Drawing.Point(81, 62);
            this.datetimetoA.Name = "datetimetoA";
            this.datetimetoA.Size = new System.Drawing.Size(210, 23);
            this.datetimetoA.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 104;
            this.label7.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 103;
            this.label8.Text = "From:";
            // 
            // cbAuditableUnit
            // 
            this.cbAuditableUnit.DataSource = this.optionABindingSource7;
            this.cbAuditableUnit.DisplayMember = "name";
            this.cbAuditableUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuditableUnit.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuditableUnit.FormattingEnabled = true;
            this.cbAuditableUnit.Location = new System.Drawing.Point(260, 83);
            this.cbAuditableUnit.Name = "cbAuditableUnit";
            this.cbAuditableUnit.Size = new System.Drawing.Size(206, 23);
            this.cbAuditableUnit.TabIndex = 121;
            this.cbAuditableUnit.ValueMember = "name";
            this.cbAuditableUnit.SelectedIndexChanged += new System.EventHandler(this.cbAuditableUnit_SelectedIndexChanged);
            // 
            // optionABindingSource7
            // 
            this.optionABindingSource7.DataMember = "OptionA";
            this.optionABindingSource7.DataSource = this.OptionaABDataSet;
            // 
            // cbAuditEngagementReferenceNo
            // 
            this.cbAuditEngagementReferenceNo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.optionABindingSource5, "engagement_ref_no", true));
            this.cbAuditEngagementReferenceNo.DataSource = this.optionABindingSource5;
            this.cbAuditEngagementReferenceNo.DisplayMember = "engagement_ref_no";
            this.cbAuditEngagementReferenceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuditEngagementReferenceNo.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuditEngagementReferenceNo.FormattingEnabled = true;
            this.cbAuditEngagementReferenceNo.Location = new System.Drawing.Point(260, 119);
            this.cbAuditEngagementReferenceNo.Name = "cbAuditEngagementReferenceNo";
            this.cbAuditEngagementReferenceNo.Size = new System.Drawing.Size(206, 23);
            this.cbAuditEngagementReferenceNo.TabIndex = 122;
            this.cbAuditEngagementReferenceNo.ValueMember = "engagement_ref_no";
            this.cbAuditEngagementReferenceNo.SelectedIndexChanged += new System.EventHandler(this.cbAuditEngagementReferenceNo_SelectedIndexChanged);
            // 
            // optionABindingSource5
            // 
            this.optionABindingSource5.DataMember = "OptionA";
            this.optionABindingSource5.DataSource = this.optionaABDataSetBindingSource1;
            // 
            // optionaABDataSetBindingSource1
            // 
            this.optionaABDataSetBindingSource1.DataSource = this.OptionaABDataSet;
            this.optionaABDataSetBindingSource1.Position = 0;
            // 
            // cbAuditFindingStatus
            // 
            this.cbAuditFindingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuditFindingStatus.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuditFindingStatus.FormattingEnabled = true;
            this.cbAuditFindingStatus.Items.AddRange(new object[] {
            "OPEN",
            "CLOSED",
            "N/A"});
            this.cbAuditFindingStatus.Location = new System.Drawing.Point(260, 155);
            this.cbAuditFindingStatus.Name = "cbAuditFindingStatus";
            this.cbAuditFindingStatus.Size = new System.Drawing.Size(206, 23);
            this.cbAuditFindingStatus.TabIndex = 123;
            this.cbAuditFindingStatus.SelectedIndexChanged += new System.EventHandler(this.cbAuditFindingStatus_SelectedIndexChanged);
            // 
            // cbRiskAssessment
            // 
            this.cbRiskAssessment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRiskAssessment.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRiskAssessment.FormattingEnabled = true;
            this.cbRiskAssessment.Items.AddRange(new object[] {
            "HIGH",
            "MODERATE - HIGH",
            "MODERATE",
            "LOW - MODERATE        ",
            "LOW"});
            this.cbRiskAssessment.Location = new System.Drawing.Point(720, 45);
            this.cbRiskAssessment.Name = "cbRiskAssessment";
            this.cbRiskAssessment.Size = new System.Drawing.Size(206, 23);
            this.cbRiskAssessment.TabIndex = 124;
            this.cbRiskAssessment.SelectedIndexChanged += new System.EventHandler(this.cbRiskAssessment_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 129;
            this.label6.Text = "Audit Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 128;
            this.label4.Text = "Auditable Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 15);
            this.label3.TabIndex = 127;
            this.label3.Text = "Audit Engagement Reference No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 126;
            this.label2.Text = "Audit Finding Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 125;
            this.label1.Text = "Risk Assessment:";
            // 
            // cbAuditGroup
            // 
            this.cbAuditGroup.DataSource = this.optionABindingSource5;
            this.cbAuditGroup.DisplayMember = "audit_group_name";
            this.cbAuditGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuditGroup.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuditGroup.FormattingEnabled = true;
            this.cbAuditGroup.Location = new System.Drawing.Point(260, 47);
            this.cbAuditGroup.Name = "cbAuditGroup";
            this.cbAuditGroup.Size = new System.Drawing.Size(206, 23);
            this.cbAuditGroup.TabIndex = 120;
            this.cbAuditGroup.ValueMember = "audit_group_name";
            this.cbAuditGroup.SelectedIndexChanged += new System.EventHandler(this.cbAuditGroup_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "NameOptionABDataSet";
            reportDataSource1.Value = this.OptionABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reports.ReportOptionA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 184);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1232, 735);
            this.reportViewer1.TabIndex = 119;
            //this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // optionABindingSource4
            // 
            this.optionABindingSource4.DataMember = "OptionA";
            this.optionABindingSource4.DataSource = this.optionaABDataSetBindingSource1;
            // 
            // optionaABDataSetBindingSource
            // 
            this.optionaABDataSetBindingSource.DataSource = this.OptionaABDataSet;
            this.optionaABDataSetBindingSource.Position = 0;
            // 
            // OptionATableAdapter
            // 
            this.OptionATableAdapter.ClearBeforeFill = true;
            // 
            // optionABindingSource1
            // 
            this.optionABindingSource1.DataMember = "OptionA";
            this.optionABindingSource1.DataSource = this.optionaABDataSetBindingSource;
            // 
            // optionABindingSource2
            // 
            this.optionABindingSource2.DataMember = "OptionA";
            this.optionABindingSource2.DataSource = this.optionaABDataSetBindingSource;
            // 
            // optionABindingSource3
            // 
            this.optionABindingSource3.DataMember = "OptionA";
            this.optionABindingSource3.DataSource = this.optionaABDataSetBindingSource;
            // 
            // optionABindingSource6
            // 
            this.optionABindingSource6.DataMember = "OptionA";
            this.optionABindingSource6.DataSource = this.optionaABDataSetBindingSource;
            // 
            // ReportOptionA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1264, 788);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportOptionA";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportOptionA";
            this.Load += new System.EventHandler(this.ReportOptionA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OptionABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionaABDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionaABDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionaABDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionABindingSource6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker datetimefromA;
        private System.Windows.Forms.DateTimePicker datetimetoA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAuditableUnit;
        private System.Windows.Forms.ComboBox cbAuditEngagementReferenceNo;
        private System.Windows.Forms.ComboBox cbAuditFindingStatus;
        private System.Windows.Forms.ComboBox cbRiskAssessment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAuditGroup;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OptionABindingSource;
        private OptionaABDataSet OptionaABDataSet;
        private OptionaABDataSetTableAdapters.OptionATableAdapter OptionATableAdapter;
        private OptionaABDataSetTableAdapters.AuditGroupTableAdapter AuditGroupTableAdapter;
        private OptionaABDataSetTableAdapters.AuditableUnitTableAdapter AuditableUnitTableAdapter;
        private System.Windows.Forms.BindingSource optionaABDataSetBindingSource;
        private System.Windows.Forms.BindingSource optionABindingSource1;
        private System.Windows.Forms.BindingSource optionABindingSource4;
        private System.Windows.Forms.BindingSource optionaABDataSetBindingSource1;
        private System.Windows.Forms.BindingSource optionABindingSource2;
        private System.Windows.Forms.BindingSource optionABindingSource3;
        private System.Windows.Forms.BindingSource optionABindingSource5;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.BindingSource optionABindingSource6;
        private System.Windows.Forms.BindingSource optionABindingSource7;

    }
}