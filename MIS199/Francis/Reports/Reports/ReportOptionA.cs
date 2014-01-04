using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Reports
{
    public partial class ReportOptionA : Form
    {
        ReportOptionADriver db;
        DataSet dataSet;
        DataTable dataTable;

        public ReportOptionA()
        {
            InitializeComponent();
        }

        private void ReportOptionA_Load(object sender, EventArgs e)
        {
           //this.OptionATableAdapter.LOAD(this.OptionaABDataSet.OptionA);
            db = new ReportOptionADriver("127.0.0.1", "root", "root", "True", "afms");
            dataSet = db.Set1();
            dataTable = db.Table1();

            reportViewer1.LocalReport.ReportPath = "D:\\Files2\\RJFiles\\School\\Ateneo\\Senior\\MIS199\\Francis\\Reports\\Reports\\Report1.rdlc";
            ReportDataSource source = new ReportDataSource("Data Source Name", dataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.LocalReport.Refresh();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void cbAuditGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
           //this.OptionATableAdapter.AuditGroup(this.OptionaABDataSet.OptionA); //Error here
            
        }

        private void generate_Click(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'OptionaABDataSet.OptionA' table. You can move, or remove it, as needed.
            //this.OptionATableAdapter.Fill(this.OptionaABDataSet.OptionA, cbAuditGroup.SelectedIndex.ToString(), cbAuditableUnit.SelectedIndex.ToString(), cbAuditEngagementReferenceNo.SelectedIndex.ToString(), cbAuditFindingStatus.SelectedIndex.ToString(), cbRiskAssessment.SelectedIndex.ToString());
            //WHERE audit_group_t.audit_group_name = @auditGroupName AND auditable_unit_t.name = @name and engagement_t.engagement_ref_no = @refno AND audit_finding_t.finding_status = @findingstatus AND audit_finding_t.risk_assessment = @riskassessment
            this.reportViewer1.RefreshReport();
        }

        private void cbAuditableUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
           // this.OptionATableAdapter.AuditUnit(this.OptionaABDataSet.OptionA, cbAuditGroup.Text);
        }

        private void cbAuditEngagementReferenceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
           // this.OptionATableAdapter.BYGROUPNAME(this.OptionaABDataSet.OptionA, cbAuditGroup.Text);
        }

        private void cbAuditFindingStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbRiskAssessment_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
