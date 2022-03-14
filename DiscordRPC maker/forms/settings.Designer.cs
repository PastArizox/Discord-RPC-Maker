
namespace DiscordRPC_maker.Forms
{
    partial class settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_titlebar_panel = new System.Windows.Forms.Panel();
            this.minimize_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.main_title_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.app_dir_button = new System.Windows.Forms.Button();
            this.app_dir_label = new System.Windows.Forms.Label();
            this.app_dir_textbox = new System.Windows.Forms.TextBox();
            this.settings_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.autorundiscord_label = new System.Windows.Forms.Label();
            this.topmost_label = new System.Windows.Forms.Label();
            this.autorundiscord_checkbox = new System.Windows.Forms.CheckBox();
            this.topmost_checkbox = new System.Windows.Forms.CheckBox();
            this.importconf_openfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.app_dir_openfolder = new System.Windows.Forms.FolderBrowserDialog();
            this.importconf_button = new System.Windows.Forms.Button();
            this.main_titlebar_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_titlebar_panel
            // 
            this.main_titlebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.main_titlebar_panel.Controls.Add(this.minimize_button);
            this.main_titlebar_panel.Controls.Add(this.close_button);
            this.main_titlebar_panel.Controls.Add(this.main_title_label);
            this.main_titlebar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_titlebar_panel.Location = new System.Drawing.Point(0, 0);
            this.main_titlebar_panel.Margin = new System.Windows.Forms.Padding(4);
            this.main_titlebar_panel.Name = "main_titlebar_panel";
            this.main_titlebar_panel.Size = new System.Drawing.Size(536, 42);
            this.main_titlebar_panel.TabIndex = 2;
            this.main_titlebar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_titlebar_panel_MouseDown);
            this.main_titlebar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_titlebar_panel_MouseMove);
            // 
            // minimize_button
            // 
            this.minimize_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimize_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.minimize_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_button.FlatAppearance.BorderSize = 0;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.minimize_button.ForeColor = System.Drawing.Color.White;
            this.minimize_button.Location = new System.Drawing.Point(468, 9);
            this.minimize_button.Margin = new System.Windows.Forms.Padding(4);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(27, 25);
            this.minimize_button.TabIndex = 6;
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // close_button
            // 
            this.close_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.close_button.ForeColor = System.Drawing.Color.White;
            this.close_button.Location = new System.Drawing.Point(503, 9);
            this.close_button.Margin = new System.Windows.Forms.Padding(4);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(27, 25);
            this.close_button.TabIndex = 5;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // main_title_label
            // 
            this.main_title_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.main_title_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_title_label.ForeColor = System.Drawing.Color.White;
            this.main_title_label.Location = new System.Drawing.Point(173, 0);
            this.main_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_title_label.MinimumSize = new System.Drawing.Size(193, 42);
            this.main_title_label.Name = "main_title_label";
            this.main_title_label.Size = new System.Drawing.Size(193, 42);
            this.main_title_label.TabIndex = 1;
            this.main_title_label.Text = "Settings";
            this.main_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_title_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_title_label_MouseDown);
            this.main_title_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_title_label_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.app_dir_button);
            this.panel1.Controls.Add(this.app_dir_label);
            this.panel1.Controls.Add(this.app_dir_textbox);
            this.panel1.Location = new System.Drawing.Point(13, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 108);
            this.panel1.TabIndex = 5;
            // 
            // app_dir_button
            // 
            this.app_dir_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.app_dir_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.app_dir_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.app_dir_button.FlatAppearance.BorderSize = 0;
            this.app_dir_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_dir_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.app_dir_button.ForeColor = System.Drawing.Color.White;
            this.app_dir_button.Location = new System.Drawing.Point(455, 63);
            this.app_dir_button.Margin = new System.Windows.Forms.Padding(4);
            this.app_dir_button.Name = "app_dir_button";
            this.app_dir_button.Size = new System.Drawing.Size(39, 28);
            this.app_dir_button.TabIndex = 47;
            this.app_dir_button.Text = "...";
            this.app_dir_button.UseVisualStyleBackColor = false;
            this.app_dir_button.Click += new System.EventHandler(this.app_dir_button_Click);
            // 
            // app_dir_label
            // 
            this.app_dir_label.AutoSize = true;
            this.app_dir_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.app_dir_label.ForeColor = System.Drawing.Color.White;
            this.app_dir_label.Location = new System.Drawing.Point(165, 23);
            this.app_dir_label.Name = "app_dir_label";
            this.app_dir_label.Size = new System.Drawing.Size(181, 21);
            this.app_dir_label.TabIndex = 46;
            this.app_dir_label.Text = "Applications directory :";
            this.app_dir_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // app_dir_textbox
            // 
            this.app_dir_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.app_dir_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.app_dir_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.app_dir_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.app_dir_textbox.ForeColor = System.Drawing.Color.White;
            this.app_dir_textbox.Location = new System.Drawing.Point(24, 63);
            this.app_dir_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.app_dir_textbox.Name = "app_dir_textbox";
            this.app_dir_textbox.Size = new System.Drawing.Size(417, 28);
            this.app_dir_textbox.TabIndex = 45;
            this.app_dir_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.settings_button.ForeColor = System.Drawing.Color.White;
            this.settings_button.Location = new System.Drawing.Point(200, 252);
            this.settings_button.Margin = new System.Windows.Forms.Padding(4);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(136, 42);
            this.settings_button.TabIndex = 7;
            this.settings_button.Text = "Cancel";
            this.settings_button.UseVisualStyleBackColor = false;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(344, 252);
            this.add_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(137, 42);
            this.add_button.TabIndex = 6;
            this.add_button.Text = "Save";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.autorundiscord_label);
            this.panel2.Controls.Add(this.topmost_label);
            this.panel2.Controls.Add(this.autorundiscord_checkbox);
            this.panel2.Controls.Add(this.topmost_checkbox);
            this.panel2.Location = new System.Drawing.Point(13, 166);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 78);
            this.panel2.TabIndex = 8;
            // 
            // autorundiscord_label
            // 
            this.autorundiscord_label.AutoSize = true;
            this.autorundiscord_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.autorundiscord_label.ForeColor = System.Drawing.Color.White;
            this.autorundiscord_label.Location = new System.Drawing.Point(247, 29);
            this.autorundiscord_label.Name = "autorundiscord_label";
            this.autorundiscord_label.Size = new System.Drawing.Size(146, 21);
            this.autorundiscord_label.TabIndex = 64;
            this.autorundiscord_label.Text = "Auto start Discord";
            this.autorundiscord_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topmost_label
            // 
            this.topmost_label.AutoSize = true;
            this.topmost_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.topmost_label.ForeColor = System.Drawing.Color.White;
            this.topmost_label.Location = new System.Drawing.Point(70, 29);
            this.topmost_label.Name = "topmost_label";
            this.topmost_label.Size = new System.Drawing.Size(74, 21);
            this.topmost_label.TabIndex = 63;
            this.topmost_label.Text = "TopMost";
            this.topmost_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autorundiscord_checkbox
            // 
            this.autorundiscord_checkbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.autorundiscord_checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.autorundiscord_checkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autorundiscord_checkbox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.autorundiscord_checkbox.FlatAppearance.BorderSize = 3;
            this.autorundiscord_checkbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.autorundiscord_checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autorundiscord_checkbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.autorundiscord_checkbox.ForeColor = System.Drawing.Color.White;
            this.autorundiscord_checkbox.Location = new System.Drawing.Point(414, 27);
            this.autorundiscord_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorundiscord_checkbox.Name = "autorundiscord_checkbox";
            this.autorundiscord_checkbox.Size = new System.Drawing.Size(27, 25);
            this.autorundiscord_checkbox.TabIndex = 62;
            this.autorundiscord_checkbox.UseVisualStyleBackColor = false;
            // 
            // topmost_checkbox
            // 
            this.topmost_checkbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.topmost_checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.topmost_checkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topmost_checkbox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.topmost_checkbox.FlatAppearance.BorderSize = 3;
            this.topmost_checkbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.topmost_checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topmost_checkbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.topmost_checkbox.ForeColor = System.Drawing.Color.White;
            this.topmost_checkbox.Location = new System.Drawing.Point(165, 27);
            this.topmost_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topmost_checkbox.Name = "topmost_checkbox";
            this.topmost_checkbox.Size = new System.Drawing.Size(27, 25);
            this.topmost_checkbox.TabIndex = 61;
            this.topmost_checkbox.UseVisualStyleBackColor = false;
            // 
            // importconf_openfiledialog
            // 
            this.importconf_openfiledialog.FileName = "Select a json file";
            this.importconf_openfiledialog.FileOk += new System.ComponentModel.CancelEventHandler(this.importconf_openfiledialog_FileOk);
            // 
            // importconf_button
            // 
            this.importconf_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.importconf_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importconf_button.FlatAppearance.BorderSize = 0;
            this.importconf_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importconf_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.importconf_button.ForeColor = System.Drawing.Color.White;
            this.importconf_button.Location = new System.Drawing.Point(56, 252);
            this.importconf_button.Margin = new System.Windows.Forms.Padding(4);
            this.importconf_button.Name = "importconf_button";
            this.importconf_button.Size = new System.Drawing.Size(136, 42);
            this.importconf_button.TabIndex = 9;
            this.importconf_button.Text = "Import config";
            this.importconf_button.UseVisualStyleBackColor = false;
            this.importconf_button.Click += new System.EventHandler(this.importconf_button_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(536, 304);
            this.Controls.Add(this.importconf_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.main_titlebar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settings_FormClosing);
            this.Load += new System.EventHandler(this.settings_Load);
            this.main_titlebar_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_titlebar_panel;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label main_title_label;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label app_dir_label;
        public System.Windows.Forms.TextBox app_dir_textbox;
        private System.Windows.Forms.Button app_dir_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox topmost_checkbox;
        internal System.Windows.Forms.Label autorundiscord_label;
        internal System.Windows.Forms.Label topmost_label;
        private System.Windows.Forms.CheckBox autorundiscord_checkbox;
        private System.Windows.Forms.OpenFileDialog importconf_openfiledialog;
        private System.Windows.Forms.FolderBrowserDialog app_dir_openfolder;
        private System.Windows.Forms.Button importconf_button;
    }
}