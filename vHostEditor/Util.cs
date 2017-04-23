using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


namespace vHostEditor
{
    public static class Util
    {
        public static string FindByDisplayName(RegistryKey parentKey, string name)
        {
            string[] nameList = parentKey.GetSubKeyNames();
            for (int i = 0; i < nameList.Length; i++)
            {
                RegistryKey regKey = parentKey.OpenSubKey(nameList[i]);
                try
                {
                    if (regKey.GetValue("DisplayName").ToString() == name)
                    {
                        return regKey.GetValue("InstallLocation").ToString();
                    }
                }
                catch { throw new Exception("Application Not Found"); }
            }
            return "";
        }


        public static string Remove(this string input, string toRemove)
        {
            return input.Replace(toRemove, "");
        }
        public static string Remove(this string input, char toRemove)
        {
            return input.Replace(toRemove, char.Parse(""));
        }
    }
}
