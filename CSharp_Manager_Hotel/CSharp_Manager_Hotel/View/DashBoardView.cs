using CSharp_Manager_Hotel.Controller;
using CSharp_Manager_Hotel.DashBoard.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Manager_Hotel.DashBoard.View
{
    public partial class DashBoardView : Form, DashBoardViewInterface
    {
        private DashBoardController controller;

        public DashBoardView()
        {
            InitializeComponent();
        }

        private void showContent(Form view)
        {
            panelContent.Controls.Clear();
            view.TopLevel = false;
            view.TopMost = true;
            panelContent.Controls.Add(view);
            view.Show();

        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            controller.showSystemScreen();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            controller.showManagerScreen();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            controller.showRecordScreen();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            controller.showAnalysisScreen();   
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            controller.showHelpScreen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void showManagerScreen(Form form)
        {
            showContent(form);
        }

        public void SetController(DashBoardController _controller)
        {
            controller = _controller;
        }

        public void showSystemScreen(SystemView form)
        {
            //showContent(form);
            form.setDashBoardView(this);
            SystemController systemController = new SystemController(form);
            panelContent.Controls.Clear();
            form.TopLevel = false;
            form.TopMost = true;
            panelContent.Controls.Add(form);
            form.Show();
        }

        public void showAnalysisScreen(Form form)
        {
            showContent(form);
        }

        public void showHelpScreen(Form form)
        {
            showContent(form);
        }

        public void showRecordScreen(Form form)
        {
            showContent(form);
        }
    }
}
