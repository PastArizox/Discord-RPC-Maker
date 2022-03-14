using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DiscordRPC_maker.src;

namespace DiscordRPC_maker.Forms
{
    public partial class settings : Form
    {
        private Param settngs;

        public settings()
        {
            InitializeComponent();
            settngs = JsonSerialization.ReadFromJsonFile<Param>($@"{utils.GetDefaultDirectory()}\config.json");
        }

        private void LoadSettings()
        {
            app_dir_textbox.Text = settngs.applicationsPath;
            topmost_checkbox.Checked = settngs.topMost;
            autorundiscord_checkbox.Checked = settngs.autoRunDiscord;
        }

        private void settings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private bool IsPath(TextBox textbox)
        {
            try
            {
                string testfile = textbox.Text + "\\test";
                FileStream file = File.Create(testfile);
                file.Close();
                File.Delete(testfile);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (IsPath(app_dir_textbox))
                settngs.applicationsPath = app_dir_textbox.Text;
            else {
                MessageBox.Show("Please enter a valid path. (Try to run as administrator)");
                return;
            }
            settngs.topMost = topmost_checkbox.Checked;
            settngs.autoRunDiscord = autorundiscord_checkbox.Checked;
            JsonSerialization.WriteToJsonFile<Param>($@"{utils.GetDefaultDirectory()}\config.json", settngs);

            Close();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void app_dir_button_Click(object sender, EventArgs e)
        {
            app_dir_openfolder.ShowNewFolderButton = true;
            DialogResult result = app_dir_openfolder.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(app_dir_openfolder.SelectedPath))
            {
                app_dir_textbox.Text = app_dir_openfolder.SelectedPath;
            }
        }

        private void importconf_button_Click(object sender, EventArgs e)
        {
            importconf_openfiledialog.Filter = "Json files (*.json) | *.json";
            DialogResult result = importconf_openfiledialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(importconf_openfiledialog.FileName))
            {
                MessageBox.Show("File imported successfully");
            }
        }

        private void importconf_openfiledialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string source = importconf_openfiledialog.FileName;
            string filename = source.Substring(source.LastIndexOf(@"\"));
            filename = filename.Replace(@"\", "");
            string target = settngs.applicationsPath + "\\" + filename;
            File.Copy(source, target, true);
        }







        // Controls

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
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

        private void settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            loader loaderform = (loader)Owner;
            loaderform.loader_Load(sender, e);
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
