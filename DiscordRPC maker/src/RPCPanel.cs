using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiscordRPC_maker.src
{
    public class RPCPanel
    {
        public Panel group_panel = new Panel();
        private Label name = new Label();

        public int Location_x;
        public int Location_y;
        public static int Width = 150;
        public static int Height = 50;

        private static int offset_top = 0;
        private static int offset_left = 0;

        public RPCObject rpc;
        private string rpc_name;

        public RPCPanel(RPCObject rpc, int x, int y)
        {
            this.rpc = rpc;
            this.Location_x = x + offset_top;
            this.Location_y = y + offset_left;
            this.rpc_name = this.rpc.rpcName;
        }

        public void Draw()
        {
            this.group_panel.Size = new Size(Width, Height);
            this.group_panel.Location = new Point(this.Location_x, this.Location_y);
            this.group_panel.BackColor = Color.FromArgb(30, 30, 30);
            this.group_panel.Cursor = Cursors.Hand;
            this.group_panel.Click += rpc_Click;

            this.name.ForeColor = Color.White;
            this.name.Text = this.rpc_name;
            this.name.Font = new Font("Tahoma", 10, FontStyle.Regular);
            this.name.Location = new Point(0, 0);
            this.name.AutoSize = false;
            this.name.Dock = DockStyle.Fill;
            this.name.Size = new Size(this.group_panel.Size.Width, this.group_panel.Size.Height / 4);
            this.name.TextAlign = ContentAlignment.MiddleCenter;
            this.name.Click += rpc_Click;

            this.group_panel.Controls.Add(this.name);
        }

        private void rpc_Click(object sender, EventArgs e)
        {
            this.group_panel.Parent.Parent.Parent.Visible = false;
            Forms.manager manager = new Forms.manager(this.rpc);
            manager.ShowDialog();
            this.group_panel.Parent.Parent.Parent.Visible = true;

            Forms.loader loaderform = (Forms.loader)this.group_panel.Parent.Parent.Parent;
            loaderform.loader_Load(sender, e);
        }
    }
}
