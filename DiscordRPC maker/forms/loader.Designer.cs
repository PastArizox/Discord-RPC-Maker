
namespace DiscordRPC_maker.Forms
{
    partial class loader
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
            this.main_title_label = new System.Windows.Forms.Label();
            this.main_titlebar_panel = new System.Windows.Forms.Panel();
            this.minimize_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.apps_container_panel = new System.Windows.Forms.Panel();
            this.settings_button = new System.Windows.Forms.Button();
            this.main_titlebar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_title_label
            // 
            this.main_title_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.main_title_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_title_label.ForeColor = System.Drawing.Color.White;
            this.main_title_label.Location = new System.Drawing.Point(311, 0);
            this.main_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_title_label.MinimumSize = new System.Drawing.Size(193, 42);
            this.main_title_label.Name = "main_title_label";
            this.main_title_label.Size = new System.Drawing.Size(193, 42);
            this.main_title_label.TabIndex = 1;
            this.main_title_label.Text = "Loader";
            this.main_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_title_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_title_label_MouseDown);
            this.main_title_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_title_label_MouseMove);
            // 
            // main_titlebar_panel
            // 
            this.main_titlebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.main_titlebar_panel.Controls.Add(this.minimize_button);
            this.main_titlebar_panel.Controls.Add(this.close_button);
            this.main_titlebar_panel.Controls.Add(this.main_title_label);
            this.main_titlebar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_titlebar_panel.Location = new System.Drawing.Point(0, 0);
            this.main_titlebar_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.main_titlebar_panel.Name = "main_titlebar_panel";
            this.main_titlebar_panel.Size = new System.Drawing.Size(813, 42);
            this.main_titlebar_panel.TabIndex = 1;
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
            this.minimize_button.Location = new System.Drawing.Point(745, 9);
            this.minimize_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.close_button.Location = new System.Drawing.Point(780, 9);
            this.close_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(27, 25);
            this.close_button.TabIndex = 5;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // add_button
            // 
            this.add_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(410, 58);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(387, 42);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // apps_container_panel
            // 
            this.apps_container_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apps_container_panel.AutoScroll = true;
            this.apps_container_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.apps_container_panel.Location = new System.Drawing.Point(16, 110);
            this.apps_container_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apps_container_panel.Name = "apps_container_panel";
            this.apps_container_panel.Size = new System.Drawing.Size(781, 276);
            this.apps_container_panel.TabIndex = 4;
            // 
            // settings_button
            // 
            this.settings_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.settings_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.settings_button.ForeColor = System.Drawing.Color.White;
            this.settings_button.Location = new System.Drawing.Point(16, 58);
            this.settings_button.Margin = new System.Windows.Forms.Padding(4);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(386, 42);
            this.settings_button.TabIndex = 5;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = false;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(813, 400);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.apps_container_panel);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.main_titlebar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(813, 400);
            this.MinimumSize = new System.Drawing.Size(373, 400);
            this.Name = "loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loader";
            this.Load += new System.EventHandler(this.loader_Load);
            this.main_titlebar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label main_title_label;
        private System.Windows.Forms.Panel main_titlebar_panel;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Panel apps_container_panel;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button settings_button;
    }
}