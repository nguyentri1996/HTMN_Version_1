using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Manager_Hotel.Model
{
    class UserModel
    {
        private int userID;
        private string username;
        private string password;
        private int typeUser;
        public int getUseID()
        {
            return userID;
        }
        public string getUserName()
        {
            return username;
        }
        public string getPassWord()
        {
            return password;
        }
        public int getTypeUser()
        {
            return typeUser;
        }

        public void setUserName(string _username)
        {
            username = _username;
        }
        public void setPassWord(string _password)
        {
            password = _password;
        }
        public void setTypeUser(int _typeUser)
        {
            typeUser = _typeUser;
        }

    }
}
