using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security;
using System.Security.AccessControl;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegisteryKeyMamut
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }


        //public static Boolean makeRegisteryKey()
        //{

        //    const string userRoot = "HKEY_CURRENT_CONFIG";
        //    const string subKey = "Software";
        //    const string keyName = userRoot + "\\" + subKey + "\\" + "Mamut Virtual Printer 6";
        //    //const string keyName = userRoot + "\\" + subKey;
        //    Console.WriteLine(keyName);
        //    //RegistrySecurity rs = new RegistrySecurity();
        //    //string user = Environment.UserDomainName + "\\" + Environment.UserName;
        //    //rs.AddAccessRule(new RegistryAccessRule(user,
        //    //    RegistryRights.WriteKey | RegistryRights.CreateSubKey,
        //    //    InheritanceFlags.None,
        //    //    PropagationFlags.None,
        //    //    AccessControlType.Allow));
        //    //RegistryKey key = Registry.CurrentUser.CreateSubKey("Testkey");
        //    //key.SetValue("Tutorial", "Yes");
        //    //key.Close();
        //    //Registry.SetValue(keyName, "Mamut Virtual Printer 6", 123);
        //    //Setvalue lager hvis det ikke eksisterer

        //    Registry.CurrentConfig.CreateSubKey(("Software" + "\\" + "Mamut Virtual Printer 6"));
        //    return true;
        //}
    }
}
