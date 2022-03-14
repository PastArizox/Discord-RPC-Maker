using System;
using System.Drawing;
using System.Windows.Forms;
using DiscordRPC_maker.src;

namespace DiscordRPC_maker.Forms
{
    public partial class addrpc : Form
    {
        private Param settngs;

        public addrpc()
        {
            InitializeComponent();
            settngs = JsonSerialization.ReadFromJsonFile<Param>($@"{utils.GetDefaultDirectory()}\config.json");
        }

        private void addrpc_Load(object sender, EventArgs e)
        {

        }

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

        private void add_button_Click(object sender, EventArgs e)
        {
            string check = CheckNeeded();
            if (check == null)
            {
                RPCObject rpc = new RPCObject(
                    rpcname_textbox.Text,
                    clientID_textbox.Text,
                    details_textbox.Text,
                    state_textbox.Text,
                    largeImageKey_textbox.Text,
                    largeImageText_textbox.Text,
                    smallImageKey_textbox.Text,
                    smallImageText_textbox.Text,
                    timestamps_checkbox.Checked,
                    button1_checkbox.Checked,
                    button1_text_textbox.Text,
                    button1_link_textbox.Text,
                    button2_checkbox.Checked,
                    button2_text_textbox.Text,
                    button2_link_textbox.Text
                );

                JsonSerialization.WriteToJsonFile<RPCObject>($@"{settngs.applicationsPath}\{rpc.rpcName}.json", rpc);

                Close();
            }
            else MessageBox.Show(check);
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }












        // Controls

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
