using CSharp_Manager_Hotel.ChangePassword.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Manager_Hotel.Controller
{
    public class ChangePasswordController
    {
        public readonly ChangePasswordView changePasswordView;
        public ChangePasswordController(ChangePasswordView _changePassWordView)
        {
            changePasswordView = _changePassWordView;
            changePasswordView.setChangePasswordController(this);
        }
    }
}
