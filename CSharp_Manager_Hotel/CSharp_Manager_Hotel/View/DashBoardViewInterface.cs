using CSharp_Manager_Hotel.DashBoard.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Manager_Hotel.DashBoard.View
{
    public interface DashBoardViewInterface
    {
        void SetController(DashBoardController _controller);
        void showManagerScreen(Form form);
        void showSystemScreen(SystemView form);
        void showAnalysisScreen(Form form);
        void showHelpScreen(Form form);
        void showRecordScreen(Form form);
    }
}
