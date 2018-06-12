using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;


namespace RegisteryKeyMamut
{
    class RegisteryKeyMamutClass
    {
        /// <summary>
        /// This class Holds the function that will fix everything
        /// </summary>


        //See summary
        public void MakeRegisteryKey()
        {
            //CurrentConfig make sure you are in "HKEY_CURRENT_CONFIG".
            //Software is the subfolder
            //We then add "\Mamut Virtual Printer 6" to make the key
            //it is supposed to be an empty key
            try
            {
                RegistryKey key = Registry.CurrentConfig.CreateSubKey(("Software" + "\\" + "Mamut Virtual Printer 6"));
                //https://stackoverflow.com/questions/7927381/programmatically-assign-the-permission-to-a-registry-subkey

                //Makes and adds Security group "Everyone" and sets permissions
                RegistrySecurity rs = key.GetAccessControl();
                IdentityReference ir = new SecurityIdentifier(WellKnownSidType.WorldSid, null);//Gets identity "Everyone"
                rs.AddAccessRule(new RegistryAccessRule(ir, RegistryRights.FullControl, AccessControlType.Allow)); //Adds access rule

                //For debug
                //ShowSecurity(rs);
            }
            catch(Exception e)
            {
                MessageBox.Show("Det skjedde en feil, kontakt Daniel");
                //For debug
                //Console.WriteLine(e);
                Application.Exit();
            }
            
        }


        //from:
        //https://msdn.microsoft.com/en-us/library/k46tz5ks(v=vs.110).aspx
        private void ShowSecurity(RegistrySecurity security)
        {
            Console.WriteLine("\r\nCurrent access rules:\r\n");

            foreach (RegistryAccessRule ar in
                security.GetAccessRules(true, true, typeof(NTAccount)))
            {
                Console.WriteLine("        User: {0}", ar.IdentityReference);
                Console.WriteLine("        Type: {0}", ar.AccessControlType);
                Console.WriteLine("      Rights: {0}", ar.RegistryRights);
                Console.WriteLine();
            }
        }
    }
}
