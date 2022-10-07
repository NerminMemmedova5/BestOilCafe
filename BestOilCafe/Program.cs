using BestOilCafe.Presenter;
using BestOilCafe.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilCafe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new HomeWindow();
            var presenter = new HomePresenter(view);

            Application.Run(view);
            
        }
    }
}
