using CSharp_Manager_Hotel.DashBoard.Controller;
using CSharp_Manager_Hotel.DashBoard.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Manager_Hotel
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
            //Application.Run(new DashBoardView());
            DashBoardView view = new DashBoardView();
            DashBoardController controller = new DashBoardController(view);
            view.ShowDialog();
        }
    }
}

