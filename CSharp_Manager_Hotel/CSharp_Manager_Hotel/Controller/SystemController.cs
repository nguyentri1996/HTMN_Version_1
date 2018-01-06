using CSharp_Manager_Hotel.ChangePassword.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Manager_Hotel.Controller
{
    public class SystemController
    {
        public readonly SystemView view;
        public ChangePasswordView changePasswordView;
        public LoginView loginView;
        public SystemController(SystemView _view)
        {
            view = _view;
            view.setController(this);
        }

        public void showChangePasswordView()
        {
            changePasswordView = new ChangePasswordView();
            view.showChangePasswordView(changePasswordView);
        }

        public void showLoginView()
        {
            loginView = new LoginView();
            view.showLoginView(loginView);
        }
    }
}
