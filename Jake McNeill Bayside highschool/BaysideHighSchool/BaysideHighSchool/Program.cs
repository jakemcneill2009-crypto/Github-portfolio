using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaysideHighSchool
{
    static class Program
    {
        public static int DisplayedResult = 0;
        public static int ReactionTestScore = 0;
        public static bool challengeComplete = false;
        public static int TotalScore = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDataEntry());
        }
    }
}
