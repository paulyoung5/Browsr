namespace Browsr
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.WindowLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SidebarTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.CloseSidebarButton = new System.Windows.Forms.Button();
            this.BrowsrLargeIcons = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SidebarIcon = new System.Windows.Forms.Button();
            this.SidebarLabel = new System.Windows.Forms.Label();
            this.SidebarTreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrowserTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.BookmarksButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.GoButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.MainOutputPanel = new System.Windows.Forms.Panel();
            this.WebsiteTabControl = new System.Windows.Forms.TabControl();
            this.AddTabButton = new System.Windows.Forms.TabPage();
            this.BrowsrSmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.WindowLayout.SuspendLayout();
            this.SidebarTableLayout.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.BrowserTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.MainOutputPanel.SuspendLayout();
            this.WebsiteTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowLayout
            // 
            this.WindowLayout.ColumnCount = 2;
            this.WindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.WindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.WindowLayout.Controls.Add(this.SidebarTableLayout, 0, 0);
            this.WindowLayout.Controls.Add(this.panel1, 1, 0);
            this.WindowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowLayout.Location = new System.Drawing.Point(0, 0);
            this.WindowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.WindowLayout.Name = "WindowLayout";
            this.WindowLayout.RowCount = 1;
            this.WindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WindowLayout.Size = new System.Drawing.Size(734, 461);
            this.WindowLayout.TabIndex = 1;
            // 
            // SidebarTableLayout
            // 
            this.SidebarTableLayout.BackColor = System.Drawing.Color.SlateGray;
            this.SidebarTableLayout.ColumnCount = 1;
            this.SidebarTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SidebarTableLayout.Controls.Add(this.panel8, 0, 0);
            this.SidebarTableLayout.Controls.Add(this.SidebarTreeView, 0, 1);
            this.SidebarTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarTableLayout.Location = new System.Drawing.Point(3, 3);
            this.SidebarTableLayout.Name = "SidebarTableLayout";
            this.SidebarTableLayout.RowCount = 2;
            this.SidebarTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SidebarTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SidebarTableLayout.Size = new System.Drawing.Size(287, 455);
            this.SidebarTableLayout.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.flowLayoutPanel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(281, 44);
            this.panel8.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.CloseSidebarButton);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(246, 0);
            this.panel9.MaximumSize = new System.Drawing.Size(35, 44);
            this.panel9.MinimumSize = new System.Drawing.Size(35, 44);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel9.Size = new System.Drawing.Size(35, 44);
            this.panel9.TabIndex = 2;
            // 
            // CloseSidebarButton
            // 
            this.CloseSidebarButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseSidebarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseSidebarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseSidebarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseSidebarButton.FlatAppearance.BorderSize = 0;
            this.CloseSidebarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseSidebarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseSidebarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseSidebarButton.ImageKey = "Close";
            this.CloseSidebarButton.ImageList = this.BrowsrLargeIcons;
            this.CloseSidebarButton.Location = new System.Drawing.Point(0, 0);
            this.CloseSidebarButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.CloseSidebarButton.Name = "CloseSidebarButton";
            this.CloseSidebarButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.CloseSidebarButton.Size = new System.Drawing.Size(25, 44);
            this.CloseSidebarButton.TabIndex = 12;
            this.toolTip1.SetToolTip(this.CloseSidebarButton, "Close sidebar");
            this.CloseSidebarButton.UseVisualStyleBackColor = false;
            this.CloseSidebarButton.Click += new System.EventHandler(this.HideSidebar);
            // 
            // BrowsrLargeIcons
            // 
            this.BrowsrLargeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BrowsrLargeIcons.ImageStream")));
            this.BrowsrLargeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.BrowsrLargeIcons.Images.SetKeyName(0, "Close");
            this.BrowsrLargeIcons.Images.SetKeyName(1, "Add");
            this.BrowsrLargeIcons.Images.SetKeyName(2, "Right");
            this.BrowsrLargeIcons.Images.SetKeyName(3, "Left");
            this.BrowsrLargeIcons.Images.SetKeyName(4, "History");
            this.BrowsrLargeIcons.Images.SetKeyName(5, "Bookmarks");
            this.BrowsrLargeIcons.Images.SetKeyName(6, "Settings");
            this.BrowsrLargeIcons.Images.SetKeyName(7, "Home");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SidebarIcon);
            this.flowLayoutPanel1.Controls.Add(this.SidebarLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(165, 44);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(165, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 44);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // SidebarIcon
            // 
            this.SidebarIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SidebarIcon.BackColor = System.Drawing.Color.Transparent;
            this.SidebarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SidebarIcon.FlatAppearance.BorderSize = 0;
            this.SidebarIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SidebarIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SidebarIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarIcon.ImageKey = "Bookmarks";
            this.SidebarIcon.ImageList = this.BrowsrLargeIcons;
            this.SidebarIcon.Location = new System.Drawing.Point(10, 10);
            this.SidebarIcon.Margin = new System.Windows.Forms.Padding(10);
            this.SidebarIcon.Name = "SidebarIcon";
            this.SidebarIcon.Size = new System.Drawing.Size(18, 18);
            this.SidebarIcon.TabIndex = 10;
            this.SidebarIcon.UseVisualStyleBackColor = false;
            // 
            // SidebarLabel
            // 
            this.SidebarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SidebarLabel.AutoSize = true;
            this.SidebarLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidebarLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidebarLabel.ForeColor = System.Drawing.Color.White;
            this.SidebarLabel.Location = new System.Drawing.Point(41, 9);
            this.SidebarLabel.Name = "SidebarLabel";
            this.SidebarLabel.Size = new System.Drawing.Size(61, 19);
            this.SidebarLabel.TabIndex = 11;
            this.SidebarLabel.Text = "Sidebar";
            // 
            // SidebarTreeView
            // 
            this.SidebarTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SidebarTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SidebarTreeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidebarTreeView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidebarTreeView.ItemHeight = 30;
            this.SidebarTreeView.LineColor = System.Drawing.Color.LightGray;
            this.SidebarTreeView.Location = new System.Drawing.Point(10, 60);
            this.SidebarTreeView.Margin = new System.Windows.Forms.Padding(10);
            this.SidebarTreeView.Name = "SidebarTreeView";
            this.SidebarTreeView.ShowLines = false;
            this.SidebarTreeView.Size = new System.Drawing.Size(267, 361);
            this.SidebarTreeView.TabIndex = 1;
            this.SidebarTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SidebarTreeView_NodeMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BrowserTableLayoutPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(296, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 455);
            this.panel1.TabIndex = 0;
            // 
            // BrowserTableLayoutPanel
            // 
            this.BrowserTableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BrowserTableLayoutPanel.ColumnCount = 1;
            this.BrowserTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BrowserTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.BrowserTableLayoutPanel.Controls.Add(this.MainOutputPanel, 0, 1);
            this.BrowserTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.BrowserTableLayoutPanel.Name = "BrowserTableLayoutPanel";
            this.BrowserTableLayoutPanel.RowCount = 2;
            this.BrowserTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.BrowserTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BrowserTableLayoutPanel.Size = new System.Drawing.Size(435, 455);
            this.BrowserTableLayoutPanel.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(429, 59);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.HistoryButton);
            this.panel4.Controls.Add(this.BookmarksButton);
            this.panel4.Controls.Add(this.SettingsButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(312, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 53);
            this.panel4.TabIndex = 2;
            // 
            // HistoryButton
            // 
            this.HistoryButton.AccessibleName = "History";
            this.HistoryButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.HistoryButton.BackColor = System.Drawing.Color.Transparent;
            this.HistoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryButton.FlatAppearance.BorderSize = 0;
            this.HistoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HistoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.ImageKey = "History";
            this.HistoryButton.ImageList = this.BrowsrLargeIcons;
            this.HistoryButton.Location = new System.Drawing.Point(10, 17);
            this.HistoryButton.Margin = new System.Windows.Forms.Padding(10);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(18, 18);
            this.HistoryButton.TabIndex = 9;
            this.toolTip1.SetToolTip(this.HistoryButton, "Show/hide the history sidebar");
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.Click += new System.EventHandler(this.ToggleSidebar);
            // 
            // BookmarksButton
            // 
            this.BookmarksButton.AccessibleName = "Bookmarks";
            this.BookmarksButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BookmarksButton.BackColor = System.Drawing.Color.Transparent;
            this.BookmarksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookmarksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookmarksButton.FlatAppearance.BorderSize = 0;
            this.BookmarksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BookmarksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BookmarksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookmarksButton.ImageKey = "Bookmarks";
            this.BookmarksButton.ImageList = this.BrowsrLargeIcons;
            this.BookmarksButton.Location = new System.Drawing.Point(48, 17);
            this.BookmarksButton.Margin = new System.Windows.Forms.Padding(10);
            this.BookmarksButton.Name = "BookmarksButton";
            this.BookmarksButton.Size = new System.Drawing.Size(18, 18);
            this.BookmarksButton.TabIndex = 10;
            this.toolTip1.SetToolTip(this.BookmarksButton, "Show/hide the bookmarks sidebar\r\n");
            this.BookmarksButton.UseVisualStyleBackColor = false;
            this.BookmarksButton.Click += new System.EventHandler(this.ToggleSidebar);
            // 
            // SettingsButton
            // 
            this.SettingsButton.AccessibleName = "Settings";
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.ImageKey = "Settings";
            this.SettingsButton.ImageList = this.BrowsrLargeIcons;
            this.SettingsButton.Location = new System.Drawing.Point(86, 17);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(10);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(18, 18);
            this.SettingsButton.TabIndex = 8;
            this.toolTip1.SetToolTip(this.SettingsButton, "Show/hide the settings menu");
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(123, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 53);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(183, 53);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(163, 33);
            this.tableLayoutPanel3.TabIndex = 5;
            this.tableLayoutPanel3.Click += new System.EventHandler(this.FocusUrl);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.GoButton);
            this.panel5.Location = new System.Drawing.Point(133, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel5.Size = new System.Drawing.Size(27, 27);
            this.panel5.TabIndex = 2;
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.Transparent;
            this.GoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoButton.FlatAppearance.BorderSize = 0;
            this.GoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoButton.ImageKey = "Right";
            this.GoButton.ImageList = this.BrowsrLargeIcons;
            this.GoButton.Location = new System.Drawing.Point(6, 6);
            this.GoButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoButton.MaximumSize = new System.Drawing.Size(16, 16);
            this.GoButton.MinimumSize = new System.Drawing.Size(16, 16);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(16, 16);
            this.GoButton.TabIndex = 1;
            this.toolTip1.SetToolTip(this.GoButton, "Go to URL");
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.UrlTextBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.panel6.Size = new System.Drawing.Size(124, 27);
            this.panel6.TabIndex = 3;
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UrlTextBox.Location = new System.Drawing.Point(5, 5);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(258, 16);
            this.UrlTextBox.TabIndex = 2;
            this.UrlTextBox.Text = "Type a web address to get started";
            this.UrlTextBox.Click += new System.EventHandler(this.CheckContents);
            this.UrlTextBox.TextChanged += new System.EventHandler(this.NewUrlTyped);
            this.UrlTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrlTextBox_KeyPress);
            this.UrlTextBox.Leave += new System.EventHandler(this.CheckContents);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.BackButton);
            this.panel7.Controls.Add(this.ForwardButton);
            this.panel7.Controls.Add(this.HomeButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 53);
            this.panel7.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Enabled = false;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ImageKey = "Left";
            this.BackButton.ImageList = this.BrowsrLargeIcons;
            this.BackButton.Location = new System.Drawing.Point(10, 17);
            this.BackButton.Margin = new System.Windows.Forms.Padding(10);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(18, 18);
            this.BackButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BackButton, "Go back");
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ForwardButton.BackColor = System.Drawing.Color.Transparent;
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForwardButton.Enabled = false;
            this.ForwardButton.FlatAppearance.BorderSize = 0;
            this.ForwardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ForwardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.ImageKey = "Right";
            this.ForwardButton.ImageList = this.BrowsrLargeIcons;
            this.ForwardButton.Location = new System.Drawing.Point(48, 17);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(10);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(18, 18);
            this.ForwardButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.ForwardButton, "Go forward");
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ImageKey = "Home";
            this.HomeButton.ImageList = this.BrowsrLargeIcons;
            this.HomeButton.Location = new System.Drawing.Point(86, 17);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(10);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(18, 18);
            this.HomeButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.HomeButton, "Visit homepage");
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MainOutputPanel
            // 
            this.MainOutputPanel.Controls.Add(this.WebsiteTabControl);
            this.MainOutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainOutputPanel.Location = new System.Drawing.Point(3, 68);
            this.MainOutputPanel.Name = "MainOutputPanel";
            this.MainOutputPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.MainOutputPanel.Size = new System.Drawing.Size(429, 384);
            this.MainOutputPanel.TabIndex = 12;
            // 
            // WebsiteTabControl
            // 
            this.WebsiteTabControl.Controls.Add(this.AddTabButton);
            this.WebsiteTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WebsiteTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebsiteTabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebsiteTabControl.HotTrack = true;
            this.WebsiteTabControl.ImageList = this.BrowsrSmallIcons;
            this.WebsiteTabControl.Location = new System.Drawing.Point(10, 0);
            this.WebsiteTabControl.Name = "WebsiteTabControl";
            this.WebsiteTabControl.Padding = new System.Drawing.Point(5, 5);
            this.WebsiteTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WebsiteTabControl.SelectedIndex = 0;
            this.WebsiteTabControl.ShowToolTips = true;
            this.WebsiteTabControl.Size = new System.Drawing.Size(409, 374);
            this.WebsiteTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.WebsiteTabControl.TabIndex = 13;
            this.WebsiteTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabWasSelected);
            // 
            // AddTabButton
            // 
            this.AddTabButton.AccessibleDescription = "Add new tab";
            this.AddTabButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTabButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTabButton.ImageKey = "Plus";
            this.AddTabButton.Location = new System.Drawing.Point(4, 30);
            this.AddTabButton.Name = "AddTabButton";
            this.AddTabButton.Padding = new System.Windows.Forms.Padding(5);
            this.AddTabButton.Size = new System.Drawing.Size(401, 340);
            this.AddTabButton.TabIndex = 1;
            this.AddTabButton.ToolTipText = "Add new tab";
            this.AddTabButton.UseVisualStyleBackColor = true;
            // 
            // BrowsrSmallIcons
            // 
            this.BrowsrSmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BrowsrSmallIcons.ImageStream")));
            this.BrowsrSmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.BrowsrSmallIcons.Images.SetKeyName(0, "Plus");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.WindowLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Browsr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.WindowLayout.ResumeLayout(false);
            this.SidebarTableLayout.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.BrowserTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.MainOutputPanel.ResumeLayout(false);
            this.WebsiteTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel WindowLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel BrowserTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BookmarksButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel MainOutputPanel;
        private System.Windows.Forms.TableLayoutPanel SidebarTableLayout;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button CloseSidebarButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label SidebarLabel;
        public System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.TabControl WebsiteTabControl;
        private System.Windows.Forms.TabPage AddTabButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TreeView SidebarTreeView;
        private System.Windows.Forms.ImageList BrowsrLargeIcons;
        private System.Windows.Forms.Button SidebarIcon;
        private System.Windows.Forms.ImageList BrowsrSmallIcons;
    }
}

