using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasariCariKart
{
    public class IniHelper
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public IniHelper(string filePath)
        {
            FILEPATH = filePath;
        }
        private string FILEPATH = String.Empty;
        private string Default { get; set; }
        public string Read(string section, string settingKey)
        {
            Default = Default ?? string.Empty;
            StringBuilder StrBuild = new StringBuilder(256);
            GetPrivateProfileString(section, settingKey, Default, StrBuild, 255, FILEPATH);
            return StrBuild.ToString();
        }
        public long Write(string section, string settingKey, string settingValue)
        {
            return WritePrivateProfileString(section, settingKey, settingValue, FILEPATH);
        }

    }
}

