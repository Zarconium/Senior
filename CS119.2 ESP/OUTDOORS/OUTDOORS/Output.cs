using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OUTDOORS
{
    public partial class Output : Form
    {
        public string OutputString
        {
            get { return tb_output.Text; }
            set { tb_output.Text = value; }
        }

        public Output()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "Transaction Report " + DateTime.Now.ToString("yyyy-MM-dd");
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);
                writer.Write(OutputString);
                writer.Close();
                fs.Close();
            }
        }
    }
}
