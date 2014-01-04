using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reports
{
    public partial class AuditTrailReport : Form
    {
        public AuditTrailReport()
        {
            InitializeComponent();
        }

        private void AuditTrailReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AuditTrailRepordDataSet.user_history_t' table. You can move, or remove it, as needed.
            this.user_history_tTableAdapter.Fill(this.AuditTrailRepordDataSet.user_history_t);

            this.reportViewer1.RefreshReport();
        }
    }
}
