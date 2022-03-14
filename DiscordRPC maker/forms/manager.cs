using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC_maker.src;

namespace DiscordRPC_maker.Forms
{
    public partial class manager : Form
    {
        private Param settngs;

        private RPCObject rpc;

        private string username;
        private int status = 0;

        public manager(RPCObject rpc)
        {
            InitializeComponent();
            this.rpc = rpc;
            main_title_label.Text += $" - {this.rpc.rpcName}";
            settngs = JsonSerialization.ReadFromJsonFile<Param>($@"{utils.GetDefaultDirectory()}\config.json");
        }

        private void SubToEvents()
        {
            rpc.client.OnConnectionEstablished += (sender, msg) => { status = 1; };

            rpc.client.OnConnectionFailed += (sender, msg) => { status = 3; };

            rpc.client.OnReady += (sender, msg) =>
            {
                status = 2;
                username = msg.User.Username;
            };

            rpc.client.OnError += (sender, msg) =>
            {
                MessageBox.Show(msg.Message);
            };
        }

        private void manager_Load(object sender, EventArgs e)
        {
            InitSettings();
        }

        private void InitSettings()
        {
            rpcname_textbox.Text = rpc.rpcName;
            clientID_textbox.Text = rpc.clientId;

            details_textbox.Text = rpc.details;
            state_textbox.Text = rpc.state;
            largeImageKey_textbox.Text = rpc.largeImageKey;
            largeImageText_textbox.Text = rpc.largeImageText;
            smallImageKey_textbox.Text = rpc.smallImageKey;
            smallImageText_textbox.Text = rpc.smallImageText;
            timestamps_checkbox.Checked = rpc.timestamps;
            button1_checkbox.Checked = rpc.button1;
            button1_text_textbox.Text = rpc.button1Text;
            button1_link_textbox.Text = rpc.button1Link;
            button2_checkbox.Checked = rpc.button2;
            button2_text_textbox.Text = rpc.button2Text;
            button2_link_textbox.Text = rpc.button2Link;
        }

        private void UpdateSettings(bool all = false)
        {
            if (all)
            {
                rpc.rpcName = rpcname_textbox.Text;
                rpc.clientId = clientID_textbox.Text;
                rpc.client = null;
            }

            rpc.details = details_textbox.Text;
            rpc.state = state_textbox.Text;
            rpc.largeImageKey = largeImageKey_textbox.Text;
            rpc.largeImageText = largeImageText_textbox.Text;
            rpc.smallImageKey = smallImageKey_textbox.Text;
            rpc.smallImageText = smallImageText_textbox.Text;
            rpc.timestamps = timestamps_checkbox.Checked;
            rpc.button1 = button1_checkbox.Checked;
            rpc.button1Text = button1_text_textbox.Text;
            rpc.button1Link = button1_link_textbox.Text;
            rpc.button2 = button2_checkbox.Checked;
            rpc.button2Text = button2_text_textbox.Text;
            rpc.button2Link = button2_link_textbox.Text;
        }

        private void status_check_timer_Tick(object sender, EventArgs e)
        {
            switch (status)
            {
                case 0:
                    SetStatusLabel("Not connected to discord", Color.Red);
                    break;
                case 1:
                    SetStatusLabel("Discord found", Color.Orange);
                    break;
                case 2:
                    SetStatusLabel($"Connected to discord as {username}", Color.LightGreen);
                    refresh_button.Visible = true;
                    deinitialize_button.Visible = true;
                    break;
                case 3:
                    SetStatusLabel("Discord not found", Color.Red);
                    break;
            }
        }

        private void SetStatusLabel(String str, Color col)
        {
            statusinfo_label.Text = str;
            statusinfo_label.ForeColor = col;
        }

        /*private void EnableEverything()
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            initialize_button.Enabled = true;
            refresh_button.Enabled = true;
            deinitialize_button.Enabled = true;
        }

        private void DisableEverything()
        {
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            initialize_button.Enabled = false;
            refresh_button.Enabled = false;
            deinitialize_button.Enabled = false;
        }*/

        private string CheckNeeded()
        {
            if (rpcname_textbox.Text == "") return "RPC Name needed";
            if (clientID_textbox.Text == "") return "Client ID needed";

            if (button1_checkbox.Checked)
            {
                if (!button1_link_textbox.Text.StartsWith("https://") &&
                    !button1_link_textbox.Text.StartsWith("http://"))
                    return "https:// or http:// needed in the link";
            }

            if (button2_checkbox.Checked)
            {
                if (!button2_link_textbox.Text.StartsWith("https://") &&
                    !button2_link_textbox.Text.StartsWith("http://"))
                    return "https:// or http:// needed in the link";
            }

            return null;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string check = CheckNeeded();
            if (check == null)
            {
                System.IO.File.Delete($@"{settngs.applicationsPath}\{rpc.rpcName}.json");
                UpdateSettings(true);
                JsonSerialization.WriteToJsonFile<RPCObject>($@"{settngs.applicationsPath}\{rpc.rpcName}.json", rpc);
            }
            else MessageBox.Show(check);

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete($@"{settngs.applicationsPath}\{rpc.rpcName}.json");
            this.Close();
        }

        private void initialize_button_Click(object sender, EventArgs e)
        {
            UpdateSettings(true);
            if (rpc.Init())
            {
                rpcname_textbox.Enabled = false;
                clientID_textbox.Enabled = false;
                update_button.Enabled = false;
                delete_button.Enabled = false;

                initialize_button.Visible = false;

                this.status_check_timer.Start();
                SubToEvents();
                rpc.InitRPC();
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            UpdateSettings();
            rpc.InitRPC();
        }

        private void deinitialize_button_Click(object sender, EventArgs e)
        {
            rpcname_textbox.Enabled = true;
            clientID_textbox.Enabled = true;
            update_button.Enabled = true;
            delete_button.Enabled = true;

            initialize_button.Visible = true;
            deinitialize_button.Visible = false;
            refresh_button.Visible = false;

            rpc.Deinitialize();
            status_check_timer.Stop();
            SetStatusLabel("Not connected to discord", Color.Red);
        }

        private void button1_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            button1_text_textbox.Enabled = !button1_text_textbox.Enabled;
            button1_link_textbox.Enabled = !button1_link_textbox.Enabled;
        }

        private void button2_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            button2_text_textbox.Enabled = !button2_text_textbox.Enabled;
            button2_link_textbox.Enabled = !button2_link_textbox.Enabled;
        }









        // Control things

        private void close_button_Click(object sender, EventArgs e)
        {
            this.rpc.Deinitialize();
            this.Close();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            /*this.Visible = false;
            hide_notifyicon.Visible = true;*/
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

        private void manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*loader loaderform = (loader)Owner;
            loaderform.loader_Load(sender, e);*/
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
