using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Führerschein
{
    public  class DatenSpeichernInWindowsRegistry
    {
        private static string keyPath = "HKEY_CURRENT_USER\\SOFTWARE\\Fhürerschein";
        private static string MiniKeyPath = "SOFTWARE\\Fhürerschein";
        private static string ValueName1 = "UserName";
        private static string ValueName2 = "Password";
        public static bool RememberUserName_PasswordUsingRegistry(string userName, string password, bool RememberMe=false)
        {
      
            if (RememberMe)
            {
                try
                {
                    if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
                    {
                        Registry.SetValue(keyPath, ValueName1, userName, RegistryValueKind.String);
                        Registry.SetValue(keyPath, ValueName2, password, RegistryValueKind.String);
                        return true;
                    }
                    else
                    {
                        using (RegistryKey Basekey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                        {
                            using(RegistryKey Key = Basekey.OpenSubKey(MiniKeyPath))
                            {
                                if(Key != null)
                                {
                                    Key.DeleteValue(ValueName1);
                                    Key.DeleteValue(ValueName2); // ich brauche hier unbedingt Bereichtigungen ......
                                }
                                return false;
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    return false;
                }

            }
            else
                return false;
        }

        public static bool LoadLoginInfoFromWidowsRegistry(ref string username, ref string password)
        {
            try
            {
                string _UserName = Registry.GetValue(keyPath, ValueName1, null) as string;
                string _Password = Registry.GetValue(keyPath, ValueName2, null) as string;

                if (_UserName != null && _Password != null)
                {
                    username = _UserName;
                    password = _Password;
                    return true;
                }
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
