using COMP123_S2019_FINALTESTA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_FINALTESTA
{
    static class Program
    {
        //this temporary
        public static MasterForm masterForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            masterForm = new MasterForm();

            Application.Run(masterForm);
        }
    }
}
