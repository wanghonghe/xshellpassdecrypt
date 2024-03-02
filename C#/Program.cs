using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace SharpXDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Xshell全版本密码一键导出工具!(支持Xshell 7.0+版本)");

            Console.WriteLine();
            if (args.Length == 1)
            {
                XClass.Decrypt(args[0]);
            }
            else
            {
                XClass.Decrypt();
            }
            Console.WriteLine("[** √] 密码导出完成! 请按任意键退出! ");
            Console.ReadKey();
        }

    }
}
