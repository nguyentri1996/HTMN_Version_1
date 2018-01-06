using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Manager_Hotel.Controller
{
    public class LoginController
    {
        public readonly LoginView loginView;
        public LoginController(LoginView _loginView)
        {
            loginView = _loginView;
            loginView.setController(this);
        }
    }
}
