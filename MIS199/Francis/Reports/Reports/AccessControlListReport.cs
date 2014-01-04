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
    public partial class AccessControlListReport : Form
    {
        public AccessControlListReport()
        {
            InitializeComponent();
        }

        private void AccessControlListReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AccessControlListDataSet.audit_user_t' table. You can move, or remove it, as needed.
            this.audit_user_tTableAdapter.Fill(this.AccessControlListDataSet.audit_user_t);

            this.reportViewer1.RefreshReport();
        }
    }
}
