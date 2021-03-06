﻿namespace Reddit_Wallpaper_Changer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.configurePanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWallpaperMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentThreadMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statuslabel = new System.Windows.Forms.Label();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.startInTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchWizardButton = new System.Windows.Forms.Button();
            this.changeTimeValue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.changeTimeType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subredditTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wallpaperGrabType = new System.Windows.Forms.ComboBox();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.redditLink = new System.Windows.Forms.LinkLabel();
            this.monitorPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.historyDataGrid = new System.Windows.Forms.DataGridView();
            this.Preview = new System.Windows.Forms.DataGridViewImageColumn();
            this.Thread = new System.Windows.Forms.DataGridViewLinkColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreadLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wallpaperChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.taskIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.startupTimer = new System.Windows.Forms.Timer(this.components);
            this.changeWallpaperTimer = new System.Windows.Forms.Timer(this.components);
            this.saveWallpaper = new System.Windows.Forms.SaveFileDialog();
            this.checkInternetTimer = new System.Windows.Forms.Timer(this.components);
            this.configureButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.breakBetweenChange = new System.Windows.Forms.Timer(this.components);
            this.monitorButton = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.useThisWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.configurePanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTimeValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.monitorPanel.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.historyPanel.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGrid)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // configurePanel
            // 
            this.configurePanel.BackColor = System.Drawing.SystemColors.Control;
            this.configurePanel.ContextMenuStrip = this.contextMenuStrip1;
            this.configurePanel.Controls.Add(this.statuslabel);
            this.configurePanel.Controls.Add(this.noticeLabel);
            this.configurePanel.Controls.Add(this.groupBox5);
            this.configurePanel.Controls.Add(this.saveButton);
            this.configurePanel.Controls.Add(this.groupBox2);
            this.configurePanel.Controls.Add(this.groupBox1);
            this.configurePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.configurePanel.Location = new System.Drawing.Point(0, 57);
            this.configurePanel.Name = "configurePanel";
            this.configurePanel.Size = new System.Drawing.Size(364, 329);
            this.configurePanel.TabIndex = 1;
            this.configurePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.configurePanel_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.changeWallpaperMenuItem,
            this.currentThreadMenuItem1,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 148);
            // 
            // statusMenuItem1
            // 
            this.statusMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.statusMenuItem1.Checked = true;
            this.statusMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusMenuItem1.ForeColor = System.Drawing.Color.YellowGreen;
            this.statusMenuItem1.Name = "statusMenuItem1";
            this.statusMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.statusMenuItem1.Text = "Running";
            this.statusMenuItem1.Click += new System.EventHandler(this.statusMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.DarkCyan;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem1.Text = "Save Wallpaper";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // changeWallpaperMenuItem
            // 
            this.changeWallpaperMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.changeWallpaperMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.changeWallpaperMenuItem.Name = "changeWallpaperMenuItem";
            this.changeWallpaperMenuItem.Size = new System.Drawing.Size(174, 22);
            this.changeWallpaperMenuItem.Text = "Change Wallpaper";
            this.changeWallpaperMenuItem.Click += new System.EventHandler(this.changeWallpaperMenuItem_Click);
            // 
            // currentThreadMenuItem1
            // 
            this.currentThreadMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.currentThreadMenuItem1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.currentThreadMenuItem1.Name = "currentThreadMenuItem1";
            this.currentThreadMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.currentThreadMenuItem1.Text = "Current Thread";
            this.currentThreadMenuItem1.Click += new System.EventHandler(this.currentThreadMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Location = new System.Drawing.Point(3, 306);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(0, 13);
            this.statuslabel.TabIndex = 12;
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.Location = new System.Drawing.Point(18, 239);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(0, 13);
            this.noticeLabel.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.autoStartCheckBox);
            this.groupBox5.Controls.Add(this.startInTrayCheckBox);
            this.groupBox5.Location = new System.Drawing.Point(15, 192);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 71);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Behind The Scenes:";
            // 
            // startInTrayCheckBox
            // 
            this.startInTrayCheckBox.AutoSize = true;
            this.startInTrayCheckBox.Location = new System.Drawing.Point(21, 22);
            this.startInTrayCheckBox.Name = "startInTrayCheckBox";
            this.startInTrayCheckBox.Size = new System.Drawing.Size(90, 17);
            this.startInTrayCheckBox.TabIndex = 3;
            this.startInTrayCheckBox.Text = "Start In Tray?";
            this.toolTip1.SetToolTip(this.startInTrayCheckBox, "Enabled, the program will start minimized.");
            this.startInTrayCheckBox.UseVisualStyleBackColor = true;
            this.startInTrayCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(293, 296);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(60, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.toolTip1.SetToolTip(this.saveButton, "Save");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.searchWizardButton);
            this.groupBox2.Controls.Add(this.changeTimeValue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.searchQuery);
            this.groupBox2.Controls.Add(this.changeTimeType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Truly Random does not use search queries.";
            this.label9.Visible = false;
            // 
            // searchWizardButton
            // 
            this.searchWizardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchWizardButton.BackgroundImage")));
            this.searchWizardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchWizardButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.searchWizardButton.Location = new System.Drawing.Point(297, 10);
            this.searchWizardButton.Name = "searchWizardButton";
            this.searchWizardButton.Size = new System.Drawing.Size(38, 33);
            this.searchWizardButton.TabIndex = 9;
            this.searchWizardButton.UseVisualStyleBackColor = true;
            this.searchWizardButton.Click += new System.EventHandler(this.searchWizardButton_Click);
            // 
            // changeTimeValue
            // 
            this.changeTimeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeTimeValue.Location = new System.Drawing.Point(202, 47);
            this.changeTimeValue.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.changeTimeValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.changeTimeValue.Name = "changeTimeValue";
            this.changeTimeValue.Size = new System.Drawing.Size(58, 20);
            this.changeTimeValue.TabIndex = 8;
            this.changeTimeValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Change Every:";
            // 
            // searchQuery
            // 
            this.searchQuery.Location = new System.Drawing.Point(133, 17);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(158, 20);
            this.searchQuery.TabIndex = 3;
            this.toolTip1.SetToolTip(this.searchQuery, "Use a query used on Reddits Search");
            this.searchQuery.TextChanged += new System.EventHandler(this.searchQuery_TextChanged);
            // 
            // changeTimeType
            // 
            this.changeTimeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeTimeType.FormattingEnabled = true;
            this.changeTimeType.Items.AddRange(new object[] {
            "Minutes",
            "Hours",
            "Days"});
            this.changeTimeType.Location = new System.Drawing.Point(266, 47);
            this.changeTimeType.Name = "changeTimeType";
            this.changeTimeType.Size = new System.Drawing.Size(69, 21);
            this.changeTimeType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reddit Search Query:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subredditTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.wallpaperGrabType);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // subredditTextBox
            // 
            this.subredditTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subredditTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.subredditTextBox.Location = new System.Drawing.Point(107, 19);
            this.subredditTextBox.Name = "subredditTextBox";
            this.subredditTextBox.Size = new System.Drawing.Size(228, 20);
            this.subredditTextBox.TabIndex = 5;
            this.subredditTextBox.Text = "wallpapers+wallpaper";
            this.toolTip1.SetToolTip(this.subredditTextBox, "Multiple subs seperated by (+) sign.");
            this.subredditTextBox.TextChanged += new System.EventHandler(this.subredditTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grab Wallpaper By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subreddit(s):";
            // 
            // wallpaperGrabType
            // 
            this.wallpaperGrabType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wallpaperGrabType.FormattingEnabled = true;
            this.wallpaperGrabType.Items.AddRange(new object[] {
            "Random",
            "Newest",
            "Hot",
            "Top This Hour",
            "Top Today",
            "Top this Week",
            "Top this Month",
            "Top this Year",
            "Top All Time",
            "Truly Random"});
            this.wallpaperGrabType.Location = new System.Drawing.Point(214, 45);
            this.wallpaperGrabType.Name = "wallpaperGrabType";
            this.wallpaperGrabType.Size = new System.Drawing.Size(121, 21);
            this.wallpaperGrabType.TabIndex = 0;
            this.toolTip1.SetToolTip(this.wallpaperGrabType, "Method of grabbing wallpaper");
            this.wallpaperGrabType.SelectedIndexChanged += new System.EventHandler(this.wallpaperGrabType_SelectedIndexChanged);
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.aboutPanel.ContextMenuStrip = this.contextMenuStrip1;
            this.aboutPanel.Controls.Add(this.groupBox3);
            this.aboutPanel.Controls.Add(this.groupBox4);
            this.aboutPanel.Location = new System.Drawing.Point(0, 57);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(364, 326);
            this.aboutPanel.TabIndex = 3;
            this.aboutPanel.Visible = false;
            this.aboutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.aboutPanel_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.versionLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(12, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 83);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.versionLabel.Location = new System.Drawing.Point(232, 27);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(0, 13);
            this.versionLabel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(148, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current Version:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Check For Updates";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.redditLink);
            this.groupBox4.Location = new System.Drawing.Point(12, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 58);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "About";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Support Subreddit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author:";
            // 
            // redditLink
            // 
            this.redditLink.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.redditLink.AutoSize = true;
            this.redditLink.DisabledLinkColor = System.Drawing.Color.SteelBlue;
            this.redditLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redditLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.redditLink.LinkColor = System.Drawing.Color.SteelBlue;
            this.redditLink.Location = new System.Drawing.Point(68, 27);
            this.redditLink.Name = "redditLink";
            this.redditLink.Size = new System.Drawing.Size(59, 13);
            this.redditLink.TabIndex = 2;
            this.redditLink.TabStop = true;
            this.redditLink.Text = "/u/Ugleh";
            this.redditLink.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.redditLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.redditLink_LinkClicked);
            // 
            // monitorPanel
            // 
            this.monitorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.monitorPanel.ContextMenuStrip = this.contextMenuStrip1;
            this.monitorPanel.Controls.Add(this.label8);
            this.monitorPanel.Controls.Add(this.button1);
            this.monitorPanel.Controls.Add(this.groupBox7);
            this.monitorPanel.Location = new System.Drawing.Point(0, 57);
            this.monitorPanel.Name = "monitorPanel";
            this.monitorPanel.Size = new System.Drawing.Size(364, 326);
            this.monitorPanel.TabIndex = 4;
            this.monitorPanel.Visible = false;
            this.monitorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.monitorPanel_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(337, 31);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nothing Here Works Yet.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.toolTip1.SetToolTip(this.button1, "Save");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox1);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.Location = new System.Drawing.Point(0, 177);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(364, 149);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Settings";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Fill",
            "Fit",
            "Stretch",
            "Center",
            "Span"});
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fill",
            "Fit",
            "Stretch",
            "Center",
            "Span"});
            this.comboBox1.Location = new System.Drawing.Point(100, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Wallpaper Type:";
            // 
            // historyPanel
            // 
            this.historyPanel.BackColor = System.Drawing.SystemColors.Control;
            this.historyPanel.Controls.Add(this.groupBox6);
            this.historyPanel.Location = new System.Drawing.Point(0, 57);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(364, 326);
            this.historyPanel.TabIndex = 5;
            this.historyPanel.Visible = false;
            this.historyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.historyPanel_Paint);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.historyDataGrid);
            this.groupBox6.Location = new System.Drawing.Point(12, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(341, 314);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "History";
            // 
            // historyDataGrid
            // 
            this.historyDataGrid.AllowUserToAddRows = false;
            this.historyDataGrid.AllowUserToDeleteRows = false;
            this.historyDataGrid.AllowUserToResizeColumns = false;
            this.historyDataGrid.AllowUserToResizeRows = false;
            this.historyDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.historyDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.historyDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Preview,
            this.Thread,
            this.OrderID,
            this.ThreadLink,
            this.imageURL});
            this.historyDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyDataGrid.Location = new System.Drawing.Point(3, 16);
            this.historyDataGrid.MultiSelect = false;
            this.historyDataGrid.Name = "historyDataGrid";
            this.historyDataGrid.ReadOnly = true;
            this.historyDataGrid.RowHeadersVisible = false;
            this.historyDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyDataGrid.ShowCellErrors = false;
            this.historyDataGrid.ShowCellToolTips = false;
            this.historyDataGrid.ShowEditingIcon = false;
            this.historyDataGrid.ShowRowErrors = false;
            this.historyDataGrid.Size = new System.Drawing.Size(335, 295);
            this.historyDataGrid.TabIndex = 1;
            this.historyDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyDataGrid_CellContentClick);
            this.historyDataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.historyDataGrid_MouseClick);
            // 
            // Preview
            // 
            this.Preview.HeaderText = "Preview";
            this.Preview.Name = "Preview";
            this.Preview.ReadOnly = true;
            // 
            // Thread
            // 
            this.Thread.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thread.HeaderText = "Thread";
            this.Thread.Name = "Thread";
            this.Thread.ReadOnly = true;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Visible = false;
            // 
            // ThreadLink
            // 
            this.ThreadLink.HeaderText = "ThreadLink";
            this.ThreadLink.Name = "ThreadLink";
            this.ThreadLink.ReadOnly = true;
            this.ThreadLink.Visible = false;
            // 
            // imageURL
            // 
            this.imageURL.HeaderText = "ImageURL";
            this.imageURL.Name = "imageURL";
            this.imageURL.ReadOnly = true;
            this.imageURL.Visible = false;
            // 
            // wallpaperChangeTimer
            // 
            this.wallpaperChangeTimer.Tick += new System.EventHandler(this.wallpaperChangeTimer_Tick);
            // 
            // taskIcon
            // 
            this.taskIcon.BalloonTipText = "Down here if you need me";
            this.taskIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.taskIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("taskIcon.Icon")));
            this.taskIcon.Text = "Reddit Wallpaper Changer";
            this.taskIcon.BalloonTipClicked += new System.EventHandler(this.taskIcon_BalloonTipClicked);
            this.taskIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.taskIcon_MouseDoubleClick);
            // 
            // startupTimer
            // 
            this.startupTimer.Interval = 1000;
            this.startupTimer.Tick += new System.EventHandler(this.startupTimer_Tick);
            // 
            // changeWallpaperTimer
            // 
            this.changeWallpaperTimer.Interval = 1000;
            this.changeWallpaperTimer.Tick += new System.EventHandler(this.changeWallpaperTimer_Tick);
            // 
            // saveWallpaper
            // 
            this.saveWallpaper.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Im" +
    "age (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            this.saveWallpaper.FilterIndex = 4;
            this.saveWallpaper.InitialDirectory = "Libraries\\Pictures";
            this.saveWallpaper.Title = "Save The Current Wallpaper";
            this.saveWallpaper.FileOk += new System.ComponentModel.CancelEventHandler(this.saveWallpaper_FileOk);
            // 
            // checkInternetTimer
            // 
            this.checkInternetTimer.Interval = 1000;
            this.checkInternetTimer.Tick += new System.EventHandler(this.checkInternetTimer_Tick);
            // 
            // configureButton
            // 
            this.configureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.configureButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.configureButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.configureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.configureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configureButton.Image = ((System.Drawing.Image)(resources.GetObject("configureButton.Image")));
            this.configureButton.Location = new System.Drawing.Point(0, -9);
            this.configureButton.Name = "configureButton";
            this.configureButton.Size = new System.Drawing.Size(91, 66);
            this.configureButton.TabIndex = 4;
            this.configureButton.Text = "Settings";
            this.configureButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.configureButton.UseVisualStyleBackColor = false;
            this.configureButton.Click += new System.EventHandler(this.configureButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.aboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.aboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.Location = new System.Drawing.Point(273, -9);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(91, 66);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "Information";
            this.aboutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.historyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.historyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.historyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Image = ((System.Drawing.Image)(resources.GetObject("historyButton.Image")));
            this.historyButton.Location = new System.Drawing.Point(91, -9);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(91, 66);
            this.historyButton.TabIndex = 6;
            this.historyButton.Text = "History";
            this.historyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // breakBetweenChange
            // 
            this.breakBetweenChange.Interval = 1000;
            this.breakBetweenChange.Tick += new System.EventHandler(this.breakBetweenChange_Tick);
            // 
            // monitorButton
            // 
            this.monitorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.monitorButton.Enabled = false;
            this.monitorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(195)))), ((int)(((byte)(228)))));
            this.monitorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.monitorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.monitorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitorButton.Image = ((System.Drawing.Image)(resources.GetObject("monitorButton.Image")));
            this.monitorButton.Location = new System.Drawing.Point(182, -9);
            this.monitorButton.Name = "monitorButton";
            this.monitorButton.Size = new System.Drawing.Size(91, 66);
            this.monitorButton.TabIndex = 7;
            this.monitorButton.Text = "Monitor";
            this.monitorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.monitorButton.UseVisualStyleBackColor = false;
            this.monitorButton.Click += new System.EventHandler(this.monitorButton_Click_1);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useThisWallpaperToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(180, 26);
            this.contextMenuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip2_ItemClicked);
            // 
            // useThisWallpaperToolStripMenuItem
            // 
            this.useThisWallpaperToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.useThisWallpaperToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.useThisWallpaperToolStripMenuItem.Name = "useThisWallpaperToolStripMenuItem";
            this.useThisWallpaperToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.useThisWallpaperToolStripMenuItem.Text = "Use This Wallpaper";
            // 
            // autoStartCheckBox
            // 
            this.autoStartCheckBox.AutoSize = true;
            this.autoStartCheckBox.Location = new System.Drawing.Point(21, 43);
            this.autoStartCheckBox.Name = "autoStartCheckBox";
            this.autoStartCheckBox.Size = new System.Drawing.Size(79, 17);
            this.autoStartCheckBox.TabIndex = 4;
            this.autoStartCheckBox.Text = "Auto Start?";
            this.toolTip1.SetToolTip(this.autoStartCheckBox, "Enabled, the program will start when Windows starts.");
            this.autoStartCheckBox.UseVisualStyleBackColor = true;
            this.autoStartCheckBox.CheckedChanged += new System.EventHandler(this.autoStartCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(364, 386);
            this.Controls.Add(this.configurePanel);
            this.Controls.Add(this.configureButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.monitorButton);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.monitorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Reddit Wallpaper Changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.configurePanel.ResumeLayout(false);
            this.configurePanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTimeValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.aboutPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.monitorPanel.ResumeLayout(false);
            this.monitorPanel.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.historyPanel.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGrid)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel configurePanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wallpaperGrabType;
        private System.Windows.Forms.Button configureButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchQuery;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.TextBox subredditTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown changeTimeValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox changeTimeType;
        private System.Windows.Forms.Timer wallpaperChangeTimer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon taskIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem currentThreadMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem changeWallpaperMenuItem;
        private System.Windows.Forms.Timer startupTimer;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView historyDataGrid;
        private System.Windows.Forms.Timer changeWallpaperTimer;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel redditLink;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox startInTrayCheckBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveWallpaper;
        private System.Windows.Forms.Timer checkInternetTimer;
        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.Button searchWizardButton;
        private System.Windows.Forms.Timer breakBetweenChange;
        private System.Windows.Forms.Button monitorButton;
        private System.Windows.Forms.Panel monitorPanel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem useThisWallpaperToolStripMenuItem;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.DataGridViewImageColumn Preview;
        private System.Windows.Forms.DataGridViewLinkColumn Thread;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreadLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageURL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox autoStartCheckBox;

    }
}

