
namespace DiscordRPC_maker.Forms
{
    partial class manager
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.main_titlebar_panel = new System.Windows.Forms.Panel();
            this.hide_button = new System.Windows.Forms.Button();
            this.minimize_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.main_title_label = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.deinitialize_button = new System.Windows.Forms.Button();
            this.initialize_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2_link_label = new System.Windows.Forms.Label();
            this.button2_link_textbox = new System.Windows.Forms.TextBox();
            this.button2_text_label = new System.Windows.Forms.Label();
            this.button2_text_textbox = new System.Windows.Forms.TextBox();
            this.button2_checkbox = new System.Windows.Forms.CheckBox();
            this.button2_label = new System.Windows.Forms.Label();
            this.button1_link_label = new System.Windows.Forms.Label();
            this.button1_link_textbox = new System.Windows.Forms.TextBox();
            this.button1_text_label = new System.Windows.Forms.Label();
            this.button1_text_textbox = new System.Windows.Forms.TextBox();
            this.button1_checkbox = new System.Windows.Forms.CheckBox();
            this.button1_label = new System.Windows.Forms.Label();
            this.timestamps_label = new System.Windows.Forms.Label();
            this.timestamps_checkbox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.smallImageText_label = new System.Windows.Forms.Label();
            this.smallImageText_textbox = new System.Windows.Forms.TextBox();
            this.smallImageKey_label = new System.Windows.Forms.Label();
            this.smallImageKey_textbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.largeImageText_label = new System.Windows.Forms.Label();
            this.largeImageText_textbox = new System.Windows.Forms.TextBox();
            this.largeImageKey_label = new System.Windows.Forms.Label();
            this.largeImageKey_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.details_label = new System.Windows.Forms.Label();
            this.state_label = new System.Windows.Forms.Label();
            this.details_textbox = new System.Windows.Forms.TextBox();
            this.state_textbox = new System.Windows.Forms.TextBox();
            this.clientID_label = new System.Windows.Forms.Label();
            this.clientID_textbox = new System.Windows.Forms.TextBox();
            this.status_label = new System.Windows.Forms.Label();
            this.statusinfo_label = new System.Windows.Forms.Label();
            this.status_check_timer = new System.Windows.Forms.Timer(this.components);
            this.rpcname_label = new System.Windows.Forms.Label();
            this.rpcname_textbox = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.hide_notifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.main_titlebar_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_titlebar_panel
            // 
            this.main_titlebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.main_titlebar_panel.Controls.Add(this.hide_button);
            this.main_titlebar_panel.Controls.Add(this.minimize_button);
            this.main_titlebar_panel.Controls.Add(this.close_button);
            this.main_titlebar_panel.Controls.Add(this.main_title_label);
            this.main_titlebar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_titlebar_panel.Location = new System.Drawing.Point(0, 0);
            this.main_titlebar_panel.Margin = new System.Windows.Forms.Padding(4);
            this.main_titlebar_panel.Name = "main_titlebar_panel";
            this.main_titlebar_panel.Size = new System.Drawing.Size(936, 42);
            this.main_titlebar_panel.TabIndex = 2;
            this.main_titlebar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_titlebar_panel_MouseDown);
            this.main_titlebar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_titlebar_panel_MouseMove);
            // 
            // hide_button
            // 
            this.hide_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hide_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(229)))), ((int)(((byte)(27)))));
            this.hide_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hide_button.FlatAppearance.BorderSize = 0;
            this.hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.hide_button.ForeColor = System.Drawing.Color.White;
            this.hide_button.Location = new System.Drawing.Point(833, 9);
            this.hide_button.Margin = new System.Windows.Forms.Padding(4);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(27, 25);
            this.hide_button.TabIndex = 7;
            this.hide_button.UseVisualStyleBackColor = false;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
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
            this.minimize_button.Location = new System.Drawing.Point(868, 9);
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
            this.close_button.Location = new System.Drawing.Point(903, 9);
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
            this.main_title_label.Location = new System.Drawing.Point(120, 0);
            this.main_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.main_title_label.MinimumSize = new System.Drawing.Size(193, 42);
            this.main_title_label.Name = "main_title_label";
            this.main_title_label.Size = new System.Drawing.Size(697, 42);
            this.main_title_label.TabIndex = 1;
            this.main_title_label.Text = "RPC Manager";
            this.main_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_title_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_title_label_MouseDown);
            this.main_title_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_title_label_MouseMove);
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.refresh_button.FlatAppearance.BorderSize = 0;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.refresh_button.ForeColor = System.Drawing.Color.White;
            this.refresh_button.Location = new System.Drawing.Point(333, 583);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(4);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(271, 39);
            this.refresh_button.TabIndex = 16;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Visible = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // deinitialize_button
            // 
            this.deinitialize_button.BackColor = System.Drawing.Color.DarkRed;
            this.deinitialize_button.FlatAppearance.BorderSize = 0;
            this.deinitialize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deinitialize_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deinitialize_button.ForeColor = System.Drawing.Color.White;
            this.deinitialize_button.Location = new System.Drawing.Point(612, 583);
            this.deinitialize_button.Margin = new System.Windows.Forms.Padding(4);
            this.deinitialize_button.Name = "deinitialize_button";
            this.deinitialize_button.Size = new System.Drawing.Size(271, 39);
            this.deinitialize_button.TabIndex = 15;
            this.deinitialize_button.Text = "Deinitialize";
            this.deinitialize_button.UseVisualStyleBackColor = false;
            this.deinitialize_button.Visible = false;
            this.deinitialize_button.Click += new System.EventHandler(this.deinitialize_button_Click);
            // 
            // initialize_button
            // 
            this.initialize_button.BackColor = System.Drawing.Color.Green;
            this.initialize_button.FlatAppearance.BorderSize = 0;
            this.initialize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initialize_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.initialize_button.ForeColor = System.Drawing.Color.White;
            this.initialize_button.Location = new System.Drawing.Point(54, 583);
            this.initialize_button.Margin = new System.Windows.Forms.Padding(4);
            this.initialize_button.Name = "initialize_button";
            this.initialize_button.Size = new System.Drawing.Size(271, 39);
            this.initialize_button.TabIndex = 14;
            this.initialize_button.Text = "Initialize";
            this.initialize_button.UseVisualStyleBackColor = false;
            this.initialize_button.Click += new System.EventHandler(this.initialize_button_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.button2_link_label);
            this.panel4.Controls.Add(this.button2_link_textbox);
            this.panel4.Controls.Add(this.button2_text_label);
            this.panel4.Controls.Add(this.button2_text_textbox);
            this.panel4.Controls.Add(this.button2_checkbox);
            this.panel4.Controls.Add(this.button2_label);
            this.panel4.Controls.Add(this.button1_link_label);
            this.panel4.Controls.Add(this.button1_link_textbox);
            this.panel4.Controls.Add(this.button1_text_label);
            this.panel4.Controls.Add(this.button1_text_textbox);
            this.panel4.Controls.Add(this.button1_checkbox);
            this.panel4.Controls.Add(this.button1_label);
            this.panel4.Controls.Add(this.timestamps_label);
            this.panel4.Controls.Add(this.timestamps_checkbox);
            this.panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(55, 352);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(828, 207);
            this.panel4.TabIndex = 40;
            // 
            // button2_link_label
            // 
            this.button2_link_label.AutoSize = true;
            this.button2_link_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2_link_label.ForeColor = System.Drawing.Color.White;
            this.button2_link_label.Location = new System.Drawing.Point(509, 150);
            this.button2_link_label.Name = "button2_link_label";
            this.button2_link_label.Size = new System.Drawing.Size(50, 21);
            this.button2_link_label.TabIndex = 70;
            this.button2_link_label.Text = "Link :";
            this.button2_link_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2_link_textbox
            // 
            this.button2_link_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2_link_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button2_link_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2_link_textbox.Enabled = false;
            this.button2_link_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2_link_textbox.ForeColor = System.Drawing.Color.White;
            this.button2_link_textbox.Location = new System.Drawing.Point(571, 145);
            this.button2_link_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.button2_link_textbox.Name = "button2_link_textbox";
            this.button2_link_textbox.Size = new System.Drawing.Size(231, 28);
            this.button2_link_textbox.TabIndex = 69;
            this.button2_link_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2_text_label
            // 
            this.button2_text_label.AutoSize = true;
            this.button2_text_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2_text_label.ForeColor = System.Drawing.Color.White;
            this.button2_text_label.Location = new System.Drawing.Point(504, 113);
            this.button2_text_label.Name = "button2_text_label";
            this.button2_text_label.Size = new System.Drawing.Size(54, 21);
            this.button2_text_label.TabIndex = 68;
            this.button2_text_label.Text = "Text :";
            this.button2_text_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2_text_textbox
            // 
            this.button2_text_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2_text_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button2_text_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button2_text_textbox.Enabled = false;
            this.button2_text_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2_text_textbox.ForeColor = System.Drawing.Color.White;
            this.button2_text_textbox.Location = new System.Drawing.Point(571, 110);
            this.button2_text_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.button2_text_textbox.Name = "button2_text_textbox";
            this.button2_text_textbox.Size = new System.Drawing.Size(231, 28);
            this.button2_text_textbox.TabIndex = 67;
            this.button2_text_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2_checkbox
            // 
            this.button2_checkbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.button2_checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2_checkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2_checkbox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2_checkbox.FlatAppearance.BorderSize = 3;
            this.button2_checkbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2_checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_checkbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2_checkbox.ForeColor = System.Drawing.Color.White;
            this.button2_checkbox.Location = new System.Drawing.Point(545, 74);
            this.button2_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2_checkbox.Name = "button2_checkbox";
            this.button2_checkbox.Size = new System.Drawing.Size(27, 25);
            this.button2_checkbox.TabIndex = 66;
            this.button2_checkbox.UseVisualStyleBackColor = false;
            this.button2_checkbox.CheckedChanged += new System.EventHandler(this.button2_checkbox_CheckedChanged);
            // 
            // button2_label
            // 
            this.button2_label.AutoSize = true;
            this.button2_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2_label.ForeColor = System.Drawing.Color.White;
            this.button2_label.Location = new System.Drawing.Point(457, 76);
            this.button2_label.Name = "button2_label";
            this.button2_label.Size = new System.Drawing.Size(73, 21);
            this.button2_label.TabIndex = 65;
            this.button2_label.Text = "Button 2";
            this.button2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1_link_label
            // 
            this.button1_link_label.AutoSize = true;
            this.button1_link_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1_link_label.ForeColor = System.Drawing.Color.White;
            this.button1_link_label.Location = new System.Drawing.Point(103, 150);
            this.button1_link_label.Name = "button1_link_label";
            this.button1_link_label.Size = new System.Drawing.Size(50, 21);
            this.button1_link_label.TabIndex = 64;
            this.button1_link_label.Text = "Link :";
            this.button1_link_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1_link_textbox
            // 
            this.button1_link_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1_link_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button1_link_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button1_link_textbox.Enabled = false;
            this.button1_link_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1_link_textbox.ForeColor = System.Drawing.Color.White;
            this.button1_link_textbox.Location = new System.Drawing.Point(164, 146);
            this.button1_link_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.button1_link_textbox.Name = "button1_link_textbox";
            this.button1_link_textbox.Size = new System.Drawing.Size(231, 28);
            this.button1_link_textbox.TabIndex = 63;
            this.button1_link_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1_text_label
            // 
            this.button1_text_label.AutoSize = true;
            this.button1_text_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1_text_label.ForeColor = System.Drawing.Color.White;
            this.button1_text_label.Location = new System.Drawing.Point(97, 113);
            this.button1_text_label.Name = "button1_text_label";
            this.button1_text_label.Size = new System.Drawing.Size(54, 21);
            this.button1_text_label.TabIndex = 62;
            this.button1_text_label.Text = "Text :";
            this.button1_text_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1_text_textbox
            // 
            this.button1_text_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1_text_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.button1_text_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button1_text_textbox.Enabled = false;
            this.button1_text_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1_text_textbox.ForeColor = System.Drawing.Color.White;
            this.button1_text_textbox.Location = new System.Drawing.Point(164, 110);
            this.button1_text_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.button1_text_textbox.Name = "button1_text_textbox";
            this.button1_text_textbox.Size = new System.Drawing.Size(231, 28);
            this.button1_text_textbox.TabIndex = 61;
            this.button1_text_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1_checkbox
            // 
            this.button1_checkbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.button1_checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1_checkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_checkbox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1_checkbox.FlatAppearance.BorderSize = 3;
            this.button1_checkbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1_checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_checkbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1_checkbox.ForeColor = System.Drawing.Color.White;
            this.button1_checkbox.Location = new System.Drawing.Point(139, 74);
            this.button1_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1_checkbox.Name = "button1_checkbox";
            this.button1_checkbox.Size = new System.Drawing.Size(27, 25);
            this.button1_checkbox.TabIndex = 60;
            this.button1_checkbox.UseVisualStyleBackColor = false;
            this.button1_checkbox.CheckedChanged += new System.EventHandler(this.button1_checkbox_CheckedChanged);
            // 
            // button1_label
            // 
            this.button1_label.AutoSize = true;
            this.button1_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1_label.ForeColor = System.Drawing.Color.White;
            this.button1_label.Location = new System.Drawing.Point(51, 76);
            this.button1_label.Name = "button1_label";
            this.button1_label.Size = new System.Drawing.Size(73, 21);
            this.button1_label.TabIndex = 59;
            this.button1_label.Text = "Button 1";
            this.button1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timestamps_label
            // 
            this.timestamps_label.AutoSize = true;
            this.timestamps_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.timestamps_label.ForeColor = System.Drawing.Color.White;
            this.timestamps_label.Location = new System.Drawing.Point(25, 32);
            this.timestamps_label.Name = "timestamps_label";
            this.timestamps_label.Size = new System.Drawing.Size(101, 21);
            this.timestamps_label.TabIndex = 37;
            this.timestamps_label.Text = "Timestamps";
            this.timestamps_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timestamps_checkbox
            // 
            this.timestamps_checkbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.timestamps_checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.timestamps_checkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timestamps_checkbox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.timestamps_checkbox.FlatAppearance.BorderSize = 3;
            this.timestamps_checkbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.timestamps_checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timestamps_checkbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.timestamps_checkbox.ForeColor = System.Drawing.Color.White;
            this.timestamps_checkbox.Location = new System.Drawing.Point(139, 31);
            this.timestamps_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timestamps_checkbox.Name = "timestamps_checkbox";
            this.timestamps_checkbox.Size = new System.Drawing.Size(27, 25);
            this.timestamps_checkbox.TabIndex = 34;
            this.timestamps_checkbox.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.smallImageText_label);
            this.panel3.Controls.Add(this.smallImageText_textbox);
            this.panel3.Controls.Add(this.smallImageKey_label);
            this.panel3.Controls.Add(this.smallImageKey_textbox);
            this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(612, 166);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 178);
            this.panel3.TabIndex = 39;
            // 
            // smallImageText_label
            // 
            this.smallImageText_label.AutoSize = true;
            this.smallImageText_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.smallImageText_label.ForeColor = System.Drawing.Color.White;
            this.smallImageText_label.Location = new System.Drawing.Point(67, 98);
            this.smallImageText_label.Name = "smallImageText_label";
            this.smallImageText_label.Size = new System.Drawing.Size(129, 21);
            this.smallImageText_label.TabIndex = 34;
            this.smallImageText_label.Text = "smallImageText";
            this.smallImageText_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smallImageText_textbox
            // 
            this.smallImageText_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.smallImageText_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallImageText_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.smallImageText_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.smallImageText_textbox.ForeColor = System.Drawing.Color.White;
            this.smallImageText_textbox.Location = new System.Drawing.Point(19, 121);
            this.smallImageText_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.smallImageText_textbox.Name = "smallImageText_textbox";
            this.smallImageText_textbox.Size = new System.Drawing.Size(231, 28);
            this.smallImageText_textbox.TabIndex = 33;
            this.smallImageText_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallImageKey_label
            // 
            this.smallImageKey_label.AutoSize = true;
            this.smallImageKey_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.smallImageKey_label.ForeColor = System.Drawing.Color.White;
            this.smallImageKey_label.Location = new System.Drawing.Point(67, 25);
            this.smallImageKey_label.Name = "smallImageKey_label";
            this.smallImageKey_label.Size = new System.Drawing.Size(123, 21);
            this.smallImageKey_label.TabIndex = 32;
            this.smallImageKey_label.Text = "smallImageKey";
            this.smallImageKey_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // smallImageKey_textbox
            // 
            this.smallImageKey_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.smallImageKey_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallImageKey_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.smallImageKey_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.smallImageKey_textbox.ForeColor = System.Drawing.Color.White;
            this.smallImageKey_textbox.Location = new System.Drawing.Point(19, 47);
            this.smallImageKey_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.smallImageKey_textbox.Name = "smallImageKey_textbox";
            this.smallImageKey_textbox.Size = new System.Drawing.Size(231, 28);
            this.smallImageKey_textbox.TabIndex = 30;
            this.smallImageKey_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.largeImageText_label);
            this.panel2.Controls.Add(this.largeImageText_textbox);
            this.panel2.Controls.Add(this.largeImageKey_label);
            this.panel2.Controls.Add(this.largeImageKey_textbox);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(333, 166);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 178);
            this.panel2.TabIndex = 38;
            // 
            // largeImageText_label
            // 
            this.largeImageText_label.AutoSize = true;
            this.largeImageText_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.largeImageText_label.ForeColor = System.Drawing.Color.White;
            this.largeImageText_label.Location = new System.Drawing.Point(67, 98);
            this.largeImageText_label.Name = "largeImageText_label";
            this.largeImageText_label.Size = new System.Drawing.Size(127, 21);
            this.largeImageText_label.TabIndex = 33;
            this.largeImageText_label.Text = "largeImageText";
            this.largeImageText_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // largeImageText_textbox
            // 
            this.largeImageText_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.largeImageText_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largeImageText_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.largeImageText_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.largeImageText_textbox.ForeColor = System.Drawing.Color.White;
            this.largeImageText_textbox.Location = new System.Drawing.Point(19, 121);
            this.largeImageText_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.largeImageText_textbox.Name = "largeImageText_textbox";
            this.largeImageText_textbox.Size = new System.Drawing.Size(231, 28);
            this.largeImageText_textbox.TabIndex = 32;
            this.largeImageText_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // largeImageKey_label
            // 
            this.largeImageKey_label.AutoSize = true;
            this.largeImageKey_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.largeImageKey_label.ForeColor = System.Drawing.Color.White;
            this.largeImageKey_label.Location = new System.Drawing.Point(69, 25);
            this.largeImageKey_label.Name = "largeImageKey_label";
            this.largeImageKey_label.Size = new System.Drawing.Size(121, 21);
            this.largeImageKey_label.TabIndex = 31;
            this.largeImageKey_label.Text = "largeImageKey";
            this.largeImageKey_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // largeImageKey_textbox
            // 
            this.largeImageKey_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.largeImageKey_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largeImageKey_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.largeImageKey_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.largeImageKey_textbox.ForeColor = System.Drawing.Color.White;
            this.largeImageKey_textbox.Location = new System.Drawing.Point(19, 47);
            this.largeImageKey_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.largeImageKey_textbox.Name = "largeImageKey_textbox";
            this.largeImageKey_textbox.Size = new System.Drawing.Size(231, 28);
            this.largeImageKey_textbox.TabIndex = 30;
            this.largeImageKey_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.details_label);
            this.panel1.Controls.Add(this.state_label);
            this.panel1.Controls.Add(this.details_textbox);
            this.panel1.Controls.Add(this.state_textbox);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(55, 166);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 178);
            this.panel1.TabIndex = 37;
            // 
            // details_label
            // 
            this.details_label.AutoSize = true;
            this.details_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.details_label.ForeColor = System.Drawing.Color.White;
            this.details_label.Location = new System.Drawing.Point(103, 25);
            this.details_label.Name = "details_label";
            this.details_label.Size = new System.Drawing.Size(62, 21);
            this.details_label.TabIndex = 33;
            this.details_label.Text = "Details";
            this.details_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.state_label.ForeColor = System.Drawing.Color.White;
            this.state_label.Location = new System.Drawing.Point(108, 96);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(49, 21);
            this.state_label.TabIndex = 32;
            this.state_label.Text = "State";
            this.state_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // details_textbox
            // 
            this.details_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.details_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.details_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.details_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.details_textbox.ForeColor = System.Drawing.Color.White;
            this.details_textbox.Location = new System.Drawing.Point(19, 47);
            this.details_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.details_textbox.Name = "details_textbox";
            this.details_textbox.Size = new System.Drawing.Size(231, 28);
            this.details_textbox.TabIndex = 31;
            this.details_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // state_textbox
            // 
            this.state_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.state_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.state_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.state_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.state_textbox.ForeColor = System.Drawing.Color.White;
            this.state_textbox.Location = new System.Drawing.Point(19, 118);
            this.state_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.state_textbox.Name = "state_textbox";
            this.state_textbox.Size = new System.Drawing.Size(231, 28);
            this.state_textbox.TabIndex = 32;
            this.state_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clientID_label
            // 
            this.clientID_label.AutoSize = true;
            this.clientID_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.clientID_label.ForeColor = System.Drawing.Color.White;
            this.clientID_label.Location = new System.Drawing.Point(71, 112);
            this.clientID_label.Name = "clientID_label";
            this.clientID_label.Size = new System.Drawing.Size(86, 21);
            this.clientID_label.TabIndex = 31;
            this.clientID_label.Text = "Client ID :";
            this.clientID_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientID_textbox
            // 
            this.clientID_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clientID_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientID_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientID_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.clientID_textbox.ForeColor = System.Drawing.Color.White;
            this.clientID_textbox.Location = new System.Drawing.Point(168, 108);
            this.clientID_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.clientID_textbox.Name = "clientID_textbox";
            this.clientID_textbox.Size = new System.Drawing.Size(231, 28);
            this.clientID_textbox.TabIndex = 30;
            this.clientID_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.status_label.ForeColor = System.Drawing.Color.White;
            this.status_label.Location = new System.Drawing.Point(16, 651);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(73, 21);
            this.status_label.TabIndex = 41;
            this.status_label.Text = "Status : ";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusinfo_label
            // 
            this.statusinfo_label.AutoSize = true;
            this.statusinfo_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.statusinfo_label.ForeColor = System.Drawing.Color.Red;
            this.statusinfo_label.Location = new System.Drawing.Point(87, 651);
            this.statusinfo_label.Name = "statusinfo_label";
            this.statusinfo_label.Size = new System.Drawing.Size(195, 21);
            this.statusinfo_label.TabIndex = 42;
            this.statusinfo_label.Text = "Not connected to discord";
            this.statusinfo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // status_check_timer
            // 
            this.status_check_timer.Interval = 500;
            this.status_check_timer.Tick += new System.EventHandler(this.status_check_timer_Tick);
            // 
            // rpcname_label
            // 
            this.rpcname_label.AutoSize = true;
            this.rpcname_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rpcname_label.ForeColor = System.Drawing.Color.White;
            this.rpcname_label.Location = new System.Drawing.Point(52, 75);
            this.rpcname_label.Name = "rpcname_label";
            this.rpcname_label.Size = new System.Drawing.Size(99, 21);
            this.rpcname_label.TabIndex = 44;
            this.rpcname_label.Text = "RPC Name :";
            this.rpcname_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpcname_textbox
            // 
            this.rpcname_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rpcname_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpcname_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rpcname_textbox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rpcname_textbox.ForeColor = System.Drawing.Color.White;
            this.rpcname_textbox.Location = new System.Drawing.Point(168, 71);
            this.rpcname_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.rpcname_textbox.Name = "rpcname_textbox";
            this.rpcname_textbox.Size = new System.Drawing.Size(231, 28);
            this.rpcname_textbox.TabIndex = 43;
            this.rpcname_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.update_button.FlatAppearance.BorderSize = 0;
            this.update_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(473, 67);
            this.update_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(196, 72);
            this.update_button.TabIndex = 45;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Tahoma", 10F);
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(687, 67);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(196, 72);
            this.delete_button.TabIndex = 46;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // hide_notifyicon
            // 
            this.hide_notifyicon.Text = "notifyIcon1";
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(936, 682);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.clientID_label);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.clientID_textbox);
            this.Controls.Add(this.rpcname_label);
            this.Controls.Add(this.rpcname_textbox);
            this.Controls.Add(this.statusinfo_label);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.deinitialize_button);
            this.Controls.Add(this.initialize_button);
            this.Controls.Add(this.main_titlebar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.manager_FormClosing);
            this.Load += new System.EventHandler(this.manager_Load);
            this.main_titlebar_panel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main_titlebar_panel;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label main_title_label;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button deinitialize_button;
        private System.Windows.Forms.Button initialize_button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox timestamps_checkbox;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label smallImageText_label;
        public System.Windows.Forms.TextBox smallImageText_textbox;
        internal System.Windows.Forms.Label smallImageKey_label;
        public System.Windows.Forms.TextBox smallImageKey_textbox;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label largeImageText_label;
        public System.Windows.Forms.TextBox largeImageText_textbox;
        internal System.Windows.Forms.Label largeImageKey_label;
        public System.Windows.Forms.TextBox largeImageKey_textbox;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label details_label;
        internal System.Windows.Forms.Label clientID_label;
        internal System.Windows.Forms.Label state_label;
        public System.Windows.Forms.TextBox clientID_textbox;
        public System.Windows.Forms.TextBox details_textbox;
        public System.Windows.Forms.TextBox state_textbox;
        internal System.Windows.Forms.Label status_label;
        internal System.Windows.Forms.Label statusinfo_label;
        private System.Windows.Forms.Timer status_check_timer;
        internal System.Windows.Forms.Label rpcname_label;
        public System.Windows.Forms.TextBox rpcname_textbox;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.NotifyIcon hide_notifyicon;
        internal System.Windows.Forms.Label timestamps_label;
        internal System.Windows.Forms.Label button2_link_label;
        public System.Windows.Forms.TextBox button2_link_textbox;
        internal System.Windows.Forms.Label button2_text_label;
        public System.Windows.Forms.TextBox button2_text_textbox;
        private System.Windows.Forms.CheckBox button2_checkbox;
        internal System.Windows.Forms.Label button2_label;
        internal System.Windows.Forms.Label button1_link_label;
        public System.Windows.Forms.TextBox button1_link_textbox;
        internal System.Windows.Forms.Label button1_text_label;
        public System.Windows.Forms.TextBox button1_text_textbox;
        private System.Windows.Forms.CheckBox button1_checkbox;
        internal System.Windows.Forms.Label button1_label;
    }
}

