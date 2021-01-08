using System;
using System.Reflection;
using System.Diagnostics;

namespace Launcher_FiveM_CS
{
    public class AboutApp
    {
        public static string version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
        public static string authors = "BigBangDBIKE#7340";
        public static string release_date = "2021-01-07";
    }
}
