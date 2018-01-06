using CSharp_Manager_Hotel.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Manager_Hotel.ChangePassword.View
{
    public partial class ChangePasswordView : Form
    {
        private ChangePasswordController changePasswordController; 
        public ChangePasswordView()
        {
            InitializeComponent();
        }

        public void setChangePasswordController(ChangePasswordController _changePasswordController)
        {
            changePasswordController = _changePasswordController;
        }

    }
}
