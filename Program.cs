using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SMDProfiler
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
            Application.Run(new SMDReflowProfiler());
        }
				private static SMDReflowProfiler transDefaultFormFrmMain = null;
				internal static SMDReflowProfiler TransDefaultFormFrmMain
				{
					get
					{
						if (transDefaultFormFrmMain == null)
						{
							transDefaultFormFrmMain = new SMDReflowProfiler();
						}
						return transDefaultFormFrmMain;
					}
				} 
    }
}
