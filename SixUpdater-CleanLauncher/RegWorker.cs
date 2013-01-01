using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace SixUpdater_CleanLauncher
{
    class RegWorker
    {
        private const string key_root = "HKEY_CURRENT_USER";
        private const string subkey = "SixUpdater-CleanLauncher";
        private const string keyName = key_root + "\\" + subkey;

        public bool saveCfgPath(string path)
        {
            try
            {
                Registry.SetValue(keyName, "cfgPath", path, RegistryValueKind.String);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public string getCfgPath()
        {
            try
            {
               return (string)Registry.GetValue(keyName, "cfgPath", "");
            }
            catch (Exception)
            {
                return "INSUFFICIENT PERMISSIONS";
            }
        }
        public bool saveSuPath(string path)
        {
            try
            {
                Registry.SetValue(keyName, "suPath", path, RegistryValueKind.String);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public string getSuPath()
        {
            try
            {
                return (string)Registry.GetValue(keyName, "suPath", "");
            }
            catch (Exception)
            {
                return "INSUFFICIENT PERMISSIONS";
            }
        }

    }
}
