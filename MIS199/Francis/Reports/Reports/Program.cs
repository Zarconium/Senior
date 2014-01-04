using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Reports
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ReportOptionA());
            //Application.Run(new ReportOptionB());
            //Application.Run(new AccessControlListReport());
            //Application.Run(new AuditTrailReport());
           //BAKIT AYAW MO GUMANA search format for running crystal report  Application.Run(new CrystalReport1());
        
        }
    }
}
