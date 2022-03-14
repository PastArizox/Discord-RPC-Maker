using System;

namespace DiscordRPC_maker.src
{
    public class Param
    {
        private string defaultPath;
        public string applicationsPath;
        public bool topMost;
        public bool autoRunDiscord;

        public Param()
        {
            defaultPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\DiscordRPC maker";
            applicationsPath = $@"{defaultPath}\applications";
            topMost = false;
            autoRunDiscord = false;
        }
    }
}
