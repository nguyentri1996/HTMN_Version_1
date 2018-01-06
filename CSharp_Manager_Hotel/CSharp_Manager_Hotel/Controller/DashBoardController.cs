using CSharp_Manager_Hotel.DashBoard.View;
using CSharp_Manager_Hotel.Modules.Analysis.View;
using CSharp_Manager_Hotel.Modules.Help.View;
using CSharp_Manager_Hotel.Modules.Manager.View;
using CSharp_Manager_Hotel.Modules.Records.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Manager_Hotel.DashBoard.Controller
{
    public class DashBoardController
    {
        public readonly DashBoardViewInterface view;
        public SystemView systemView;
        public ManagerView managerView;
        public AnalysisView analysisView;
        public HelpView helpView;
        public RecordView recordView;
        public DashBoardController(DashBoardViewInterface _view)
        {
            view = _view;
            view.SetController(this);
        }

        public void showSystemScreen()
        {
            systemView = new SystemView();
            view.showSystemScreen(systemView);
        }

        public void showManagerScreen()
        {
            managerView = new ManagerView();
            view.showManagerScreen(managerView);
        }
        public void showAnalysisScreen()
        {
            analysisView = new AnalysisView();
            view.showAnalysisScreen(analysisView);
        }
        public void showHelpScreen()
        {
            helpView = new HelpView();
            view.showHelpScreen(helpView);
        }
        public void showRecordScreen()
        {
            recordView = new RecordView();
            view.showRecordScreen(recordView);
        }

    }
}
