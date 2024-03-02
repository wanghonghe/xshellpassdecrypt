using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;

namespace SharpXDecrypt
{
    class Utils
    {
        public struct UserSID
        {
            public string Name;
            public string SID;
        }
        public static UserSID GetUserSID()
        {
            UserSID userSID;
            Console.WriteLine("[*] 开始获取当前用户SID....");
            WindowsIdentity current = WindowsIdentity.GetCurrent();
            userSID.Name = current.Name.ToString().Split('\\')[1];
            userSID.SID = current.User.ToString();
            Console.WriteLine("  用户名: " + userSID.Name);
            Console.WriteLine("  用户SID: " + userSID.SID);
            Console.WriteLine("[** √] 获取当前用户SID成功 !");
            Console.WriteLine();
            return userSID;
        }
    }
}
