using CSharp_Manager_Hotel.ChangePassword.View;
using CSharp_Manager_Hotel.Controller;
using CSharp_Manager_Hotel.DashBoard.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Manager_Hotel
{
    public partial class SystemView : Form
    {
        private SystemController systemController;
        public DashBoardView dashboardView;
        public SystemView()
        {
            InitializeComponent();
        }

        public void setController(SystemController _systemController)
        {
            systemController = _systemController;
        }
        
        public void setDashBoardView(DashBoardView _dashBoardView)
        {
            dashboardView = _dashBoardView;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            systemController.showLoginView();

        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            systemController.showChangePasswordView();
        }

        public void showChangePasswordView(ChangePasswordView _changePasswordView)
        {
            dashboardView.panelContent.Controls.Clear();
            _changePasswordView.TopLevel = false;
            _changePasswordView.TopMost = true;
            dashboardView.panelContent.Controls.Add(_changePasswordView);
            _changePasswordView.Show();
        }

        public void showLoginView(LoginView _loginView)
        {
            dashboardView.panelContent.Controls.Clear();
            _loginView.TopLevel = false;
            _loginView.TopMost = true;
            dashboardView.panelContent.Controls.Add(_loginView);
            _loginView.Show();
        }
    }
}
