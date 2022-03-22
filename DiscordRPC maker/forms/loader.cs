using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DiscordRPC_maker.src;
using System.IO;
using System.Drawing;
using System.Diagnostics;

/*

    Add features :

Options : Auto start at windows start

*/

namespace DiscordRPC_maker.Forms
{
    public partial class loader : Form
    {

        private Param settings;

        public loader()
        {
            InitializeComponent();
        }

        private void InitFolder()
        {
            if (!Directory.Exists(utils.GetDefaultDirectory()))
                Directory.CreateDirectory(utils.GetDefaultDirectory());

            if (!Directory.Exists($@"{utils.GetDefaultDirectory()}\applications"))
                Directory.CreateDirectory($@"{utils.GetDefaultDirectory()}\applications");
        }

        private Param InitSettings()
        {
            Param newSettings = new Param();
            string configPath = $@"{utils.GetDefaultDirectory()}\config.json";
            if (!File.Exists(configPath))
            {
                JsonSerialization.WriteToJsonFile<Param>(configPath, newSettings);
            }
            newSettings = JsonSerialization.ReadFromJsonFile<Param>(configPath);
            return newSettings;
        }

        private void RunSettings()
        {
            TopMost = settings.topMost;
            if (settings.autoRunDiscord) RunDiscord();
        }

        private void RunDiscord()
        {
            if (utils.GetDiscordState())
                return;

            try { Process.Start(utils.GetDiscordPath()); }
            catch (Exception e)
            {
                if (e is FileNotFoundException) MessageBox.Show("Couldn't find Discord.exe");
                else MessageBox.Show("Couldn't start Discord");
            }
        }

        public List<RPCObject> InitRPCTab()
        {
            List<RPCObject> rpcs = new List<RPCObject>();
            String[] files = Directory.GetFiles(settings.applicationsPath, "*.json");
            foreach (String file in files)
            {
                rpcs.Add(JsonSerialization.ReadFromJsonFile<RPCObject>(file));
            }
            return rpcs;
        }

        public void AddRPCSInPanel(List<RPCObject> rpcs)
        {
            int x = 100;
            int y = 10;
            int offset = 15;
            int maxpanelsx = 0;
            int maxpanelsy = 1;

            Panel center_panel = new Panel();
            center_panel.Size = new Size(0, 0);
            center_panel.Location = new Point(0, 0);

            foreach (RPCObject rpc in rpcs)
            {
                if (x < apps_container_panel.Width - RPCPanel.Width)
                {
                    RPCPanel rpcPanel = new RPCPanel(rpc, x - 100, y - 10);
                    rpcPanel.Draw();
                    center_panel.Controls.Add(rpcPanel.group_panel);
                    x += RPCPanel.Width + offset;

                    if (y == 10)
                        maxpanelsx++;
                }
                else
                {
                    x = 100;
                    y += RPCPanel.Height + offset;
                    RPCPanel Test1 = new RPCPanel(rpc, x - 100, y - 10);
                    Test1.Draw();
                    center_panel.Controls.Add(Test1.group_panel);
                    x += RPCPanel.Width + offset;

                    maxpanelsy++;
                }
            }

            center_panel.Size = new Size(maxpanelsx * RPCPanel.Width + (maxpanelsx - 1) * offset, maxpanelsy * RPCPanel.Height + (maxpanelsy - 1) * offset);
            int locx = (apps_container_panel.Width - center_panel.Width) / 2;
            center_panel.Location = new Point(locx, 10);
            apps_container_panel.Controls.Add(center_panel);
            apps_container_panel.SetAutoScrollMargin(0, 10);
        }

        public void loader_Load(object sender, EventArgs e)
        {
            InitFolder();
            settings = InitSettings();
            RunSettings();
            apps_container_panel.Controls.Clear();
            List<RPCObject> rpcs = InitRPCTab();
            AddRPCSInPanel(rpcs);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            addrpc addrpcform = new addrpc();
            Visible = false;
            addrpcform.ShowDialog(this);
            Visible = true;
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            settings settingsform = new settings();
            Visible = false;
            settingsform.ShowDialog(this);
            Visible = true;
        }









        // Controls

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        int X, Y;
        Point NewPoint = new Point();

        private void main_titlebar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            X = Control.MousePosition.X - this.Location.X;
            Y = Control.MousePosition.Y - this.Location.Y;
        }

        private void main_titlebar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NewPoint = Control.MousePosition;
                NewPoint.X -= (X);
                NewPoint.Y -= (Y);
                Location = NewPoint;
            }
        }

        private void main_title_label_MouseDown(object sender, MouseEventArgs e)
        {
            X = Control.MousePosition.X - this.Location.X;
            Y = Control.MousePosition.Y - this.Location.Y;
        }

        private void main_title_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NewPoint = Control.MousePosition;
                NewPoint.X -= (X);
                NewPoint.Y -= (Y);
                Location = NewPoint;
            }
        }
    }
}
