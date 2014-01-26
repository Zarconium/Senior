using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            transactionType.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (transactionType.SelectedIndex == 0)
            {
                receipts_gb.Visible = true;

                adjustments_gb.Visible = false;
                costChanges_gb.Visible = false;
                costModifications_gb.Visible = false;
                transfersOut_gb.Visible = false;
                transfersIn_gb.Visible = false;
            }

            if (transactionType.SelectedIndex == 1)
            {
                adjustments_gb.Visible = true;

                receipts_gb.Visible = false;
                costChanges_gb.Visible = false;
                costModifications_gb.Visible = false;
                transfersOut_gb.Visible = false;
                transfersIn_gb.Visible = false;
            }

            if (transactionType.SelectedIndex == 2)
            {
                costChanges_gb.Visible = true;

                adjustments_gb.Visible = false;
                receipts_gb.Visible = false;
                costModifications_gb.Visible = false;
                transfersOut_gb.Visible = false;
                transfersIn_gb.Visible = false;
            }

            if (transactionType.SelectedIndex == 3)
            {
                costModifications_gb.Visible = true;

                costChanges_gb.Visible = false;
                adjustments_gb.Visible = false;
                receipts_gb.Visible = false;
                transfersOut_gb.Visible = false;
                transfersIn_gb.Visible = false;
            }

            if (transactionType.SelectedIndex == 4)
            {
                transfersOut_gb.Visible = true;

                costModifications_gb.Visible = false;
                costChanges_gb.Visible = false;
                adjustments_gb.Visible = false;
                receipts_gb.Visible = false;
                transfersIn_gb.Visible = false;
            }

            if (transactionType.SelectedIndex == 5)
            {
                transfersIn_gb.Visible = true;

                transfersOut_gb.Visible = false;
                costModifications_gb.Visible = false;
                costChanges_gb.Visible = false;
                adjustments_gb.Visible = false;
                receipts_gb.Visible = false;
               
            }
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void transactionDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
