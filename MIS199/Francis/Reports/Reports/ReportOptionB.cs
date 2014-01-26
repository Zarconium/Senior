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
    public partial class ReportOptionB : Form
    {
        public ReportOptionB()
        {
            InitializeComponent();
        }

        private void ReportOptionB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OptionaABDataSet.OptionB' table. You can move, or remove it, as needed.
            this.OptionBTableAdapter.Fill(this.OptionaABDataSet.OptionB);
            // TODO: This line of code loads data into the 'OptionaABDataSet.OptionA' table. You can move, or remove it, as needed.
           // this.OptionATableAdapter.Fill(this.OptionaABDataSet.OptionA);
            // TODO: This line of code loads data into the 'OptionaABDataSet.OptionA' table. You can move, or remove it, as needed.
           // this.OptionATableAdapter.Fill(this.OptionaABDataSet.OptionA);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
