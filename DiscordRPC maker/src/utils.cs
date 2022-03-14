using System;
using System.IO;

namespace DiscordRPC_maker.src
{
    public static class utils
    {
        public static string GetDefaultDirectory()
        {
            return $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\DiscordRPC maker";
        }

        public static bool GetDiscordState()
        {
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("Discord");
            if (processes.Length == 0) return false;
            else return true;
        }
        
        public static string GetDiscordPath()
        {
            string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Discord";
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                if (dir.StartsWith(path + "\\app-"))
                {
                    path = dir + "\\Discord.exe";
                    break;
                }
            }
            return path;
        }
    }
}
