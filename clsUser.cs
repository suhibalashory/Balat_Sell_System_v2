using System;
using System.Collections.Generic;
using System.Xml.Linq;
using DataLeayrs;

namespace BissnussLayer
{
    public class clsUser
    {
        enum Mode { Add , Update }
        Mode _mode = Mode.Add;

        public int ID {  get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool IsAdmin { get; set; }


        public clsUser(int iD, string userName, string userPassword, bool isAdmin)
        {
            ID = iD;
            UserName = userName;
            UserPassword = userPassword;
            IsAdmin = isAdmin;

            _mode = Mode.Update;
        }

        public clsUser()
        {
            this.ID = 0;
            this.UserName = string.Empty;
            this.UserPassword = string.Empty;
            this.IsAdmin = false;

            _mode = Mode.Add;
        }


        public static clsUser GetUserBy_Name_Password(string name,string password)
        {
            int id = 0;
            bool admin = false;

            bool found = UserData.GetUserInfo_By_Name_password(ref id, name, password,ref admin);

            if(found) 
                return new clsUser(id,name,password,admin);
            else 
                return null;
        }

        public static List<string> GetUserNames()
        {
            return UserData.GetAllUsersName();
        }

        public bool Save()
        {
            return true;
        }
    }
}
