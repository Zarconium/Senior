using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SYSPROWCFServicesClientLibrary40;

namespace OUTDOORS
{
    public partial class Invqry : Form
    {
        public Invqry()
        {
            InitializeComponent();
        }

        private void button_invqry_Click(object sender, EventArgs e)
        {
            try
            {
                SYSPROWCFServicesPrimitiveClient sc = new SYSPROWCFServicesPrimitiveClient("net.tcp://10.2.3.10:500/SYSPROWCFService/Soap", SYSPROWCFBinding.NetTcp);
                string guid = sc.Logon("ENET5", "", "0", "");
                string XMLin = "<Query><Key><StockCode><![CDATA[" + tb_invqry_stockCode.Text + "]]></StockCode></Key></Query>";
                
                MessageBox.Show(sc.QueryQuery(guid, "INVQRY", XMLin), "Item [" + tb_invqry_stockCode.Text + "]");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
