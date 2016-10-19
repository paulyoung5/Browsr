using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Browsr
{
    public partial class MainWindow : Form
    {

        private bool sidebarShown;
        private String currentSidebarState = "";

        private Browsr Browsr {
            get; set;
        }

        public int totalTabCount;

        public MainWindow() {
            InitializeComponent();

            Browsr = new Browsr();
        }

        private void MainWindow_Load(object sender, EventArgs e) {

            this.sidebarShown = false;
            WindowLayout.ColumnStyles[0].Width = 0;

            if((bool) Browsr.Settings["ShowHomepage"])
                OpenHomepage(AddTab());
            else
                AddTab();

        }

        private void OpenHomepage(TabPage tab) {

            // Get the response and
            // Update the GUI
            OpenPage(tab, Browsr.Homepage.Url);
            UrlTextBox.Text = Browsr.Homepage.Url;
            tab.Text = Browsr.Homepage.Title;
            WebsiteTabControl.SelectedTab = tab;

        }

        private String GetBasicTitle(String url) {

            try {
                return new Uri(url).Host;
            } catch {
                return url;
            }

        }

        private String VisitURL(String url) {

            // Perform HTTP request for the url
            return new HTTP().Get(url);

        }

        private void OpenPage(TabPage source, String url) {

            String title = GetBasicTitle(url);

            var page = GetOutputArea(source);

            String output = "";

            var thread = new Thread(() => {
                output = VisitURL(url);
            });

            thread.Start();

            // Update tab properties, add to history
            var tab = Browsr.Tabs.Items[Browsr.Tabs.FindKeyByTitle(page.Text)];
            Browsr.History.AddItem(new Item(GetBasicTitle(url), url));
            tab.Update(title, url);

            ConfigureHistoryButtons();

            // If history is open, we need to add this new URL to the GUI
            if(SidebarLabel.Text == "History" && this.sidebarShown) {
                TreeNode newNode = SidebarTreeView.Nodes.Insert(0, title);
                newNode.Nodes.Insert(0, url);
            }

            thread.Join();

            // Update tab title and output
            source.Text = title;
            page.Text = output;

        }

        private TextBox GetOutputArea(TabPage source) {
            return ((source as TabPage).Controls[0] as TableLayoutPanel).GetControlFromPosition(0, 1) as TextBox;
        }

        private void GoButton_Click(object sender, EventArgs e) {

            // Get the currently selected tab's output area
            // The only child within the tab page should be the output area

            var url = UrlTextBox.Text;
            var title = GetBasicTitle(url);

            var source = WebsiteTabControl.SelectedTab;
            
            // Update address bar and tab title
            UrlTextBox.Text = url;
            source.Text = title;

            OpenPage(source, url);

            GoButton.Visible = false;

        }

        private void NewUrlTyped(object sender, EventArgs e) {
            GoButton.Visible = true;
        }

        private void FocusUrl(object sender, EventArgs e)
        {
            this.ActiveControl = UrlTextBox;
        }

        private void CheckContents(object sender, EventArgs e)
        {

            String old = UrlTextBox.Text;
            String placeholder = "Type a web address to get started";

            if (String.IsNullOrEmpty(old))
            {
                UrlTextBox.Text = placeholder;
            } else if (old == placeholder)
            {
                UrlTextBox.Clear();
            }
        }

        private void HideSidebar(object sender, EventArgs e) {

            WindowLayout.ColumnStyles[0].Width = 0;
            this.sidebarShown = false;
            this.currentSidebarState = "";

        }

        public void SidebarTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            if(e.Node.Nodes.Count == 0)
                OpenPage(WebsiteTabControl.SelectedTab, e.Node.Text);
        }

        private void PopulateSidebar(String state) {

            SidebarTreeView.Nodes.Clear();
            
            TreeNode title, url;
            ItemManager<Item> mgr;

            if(state == "History")
                mgr = Browsr.History;
            else
                mgr = Browsr.Bookmarks;

            for(int i = 0; i < mgr.Items.Count; i++) {

                var item = mgr.Items[i];

                title = SidebarTreeView.Nodes.Insert(i, item.Title);
                url = title.Nodes.Insert(i, item.Url);

            }

        }

        private void ShowSidebar(String state) {

            WindowLayout.ColumnStyles[0].Width = 30;
            this.sidebarShown = true;
            this.currentSidebarState = state;

            PopulateSidebar(state);

        }

        private void ToggleSidebar(Object sender, EventArgs e) {

            var source = sender as Button;

            // Boolean that indicates one sidebar is already open, and we want to swap to another e.g. pressing history while bookmarks is open
            bool swapping = (this.currentSidebarState != source.AccessibleName
                && this.sidebarShown);

            // Check if the sidebar is hidden, or if we want to swap sidebars
            if(!this.sidebarShown || swapping) {

                SidebarLabel.Text = source.AccessibleName;

                SidebarIcon.ImageKey = source.ImageKey;

                ShowSidebar(source.AccessibleName);


            } else {

                HideSidebar(sender, e);
                return;

            }

        }

        private void UrlTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
                GoButton_Click(sender, e);

        }

        private TableLayoutPanel GetTabBody() {

            // Set up the body of the tab as a table
            TableLayoutPanel body = new System.Windows.Forms.TableLayoutPanel();

            // Customise its properties
            body.BackColor = System.Drawing.SystemColors.Window;
            body.ColumnCount = 1;
            body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            body.Dock = System.Windows.Forms.DockStyle.Fill;
            body.Location = new System.Drawing.Point(0, 0);
            body.Name = "BrowserTableLayoutPanel";
            body.RowCount = 2;
            body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize, 40F));
            body.RowStyles.Add(new System.Windows.Forms.RowStyle());
            body.Size = new System.Drawing.Size(435, 455);
            body.Margin = new Padding(0);
            body.Padding = new Padding(0);
            body.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            body.Cursor = Cursors.Default;



            // Create the tab toolstrip bar and output area
            ToolStrip tabTools = CreateTabTools();
            TextBox outputArea = new TextBox();

            // Output area configuration
            outputArea.Multiline = true;
            outputArea.Dock = DockStyle.Fill;
            outputArea.ReadOnly = true;
            outputArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            outputArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            outputArea.BackColor = SystemColors.Window;
            outputArea.Margin = new Padding(5, 0, 5, 5);
            outputArea.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);


            // Now add the tab tools and output area to the tab body
            body.Controls.Add(tabTools, 0, 0);
            body.Controls.Add(outputArea, 0, 1);

            // Finally, return the tab body (TableLayoutPanel)
            return body;

        }

        private TabPage NewTab(TabControl source, String title, String url) {

            // Create and add a new tab to the control
            TabPage tab = new TabPage(title);
            tab.Padding = new Padding(0);

            // Set up the body of the tab as a table
            TableLayoutPanel tabBody = GetTabBody();

            tab.Controls.Add(tabBody);

            int index = (source.TabPages.Count > 1) ? source.TabPages.Count - 1 : 0;

            source.TabPages.Insert(index, tab);

            // Add the tab to the data structure
            Browsr.Tabs.AddItem(new Tab("New tab " + totalTabCount, "", index));

            return tab;

        }

        private TabPage AddTab() {

            ++totalTabCount;

            var source = WebsiteTabControl;

            // Create and add a new tab to the control
            TabPage newTab = NewTab(source, "New tab " + totalTabCount, "");

            // Now set the selected tab to the latest one; this should be the last one
            source.SelectedIndex = (source.TabCount > 1) ? source.TabCount - 2 : 0;

            // Return the TabPage element so we can use this method in a chained manner
            return newTab;

        }

        private void OpenSettings() {

            new Settings(Browsr).ShowDialog();

        }

        private void CloseTab() {

            TabPage selected = WebsiteTabControl.SelectedTab;

            // Find the index of the tab to be removed (relative to the tab data structure)
            var key = Browsr.Tabs.FindKeyByTitle(selected.Text);
            // Remove it
            Browsr.Tabs.RemoveItem(key);

            if(WebsiteTabControl.TabPages.Count <= 2)
                AddTab();

            WebsiteTabControl.TabPages.Remove(selected);

        }

        private void TabWasSelected(object sender, TabControlEventArgs e) {

            var source = sender as TabControl;

            var selectedTab = source.SelectedTab;

            // Check if we need to add a new tab
            if(selectedTab == null) {
                return; // The program has just opened, there's not selected tab yet!
            } else if(selectedTab.Name == "AddTabButton") {

                AddTab();
                FocusUrl(sender, e);

            } else {

                // Change address bar..
                var selected = WebsiteTabControl.SelectedTab;
                int key = Browsr.Tabs.FindKeyByTitle(selected.Text);

                UrlTextBox.Text = Browsr.Tabs.Items[key].Url;

                // Enable/disable next/prev buttons as appropriate
                ConfigureHistoryButtons();

            }

        }

        private void ConfigureHistoryButtons() {

            int key = Browsr.Tabs.FindKeyByTitle(WebsiteTabControl.SelectedTab.Text);

            ForwardButton.Enabled = Browsr.Tabs.Items[key].hasNext();
            BackButton.Enabled = Browsr.Tabs.Items[key].hasPrev();
        }

        private void HomeButton_Click(object sender, EventArgs e) {
            OpenHomepage(WebsiteTabControl.SelectedTab);
        }

        private ToolStrip CreateTabTools() {

            ToolStrip TabToolStrip = new System.Windows.Forms.ToolStrip();
            ToolStripButton CloseTabButton = new ToolStripButton();
            ToolStripButton BookmarkTabButton = new ToolStripButton();

            TabToolStrip.RenderMode = ToolStripRenderMode.System;
            TabToolStrip.GripMargin = new Padding(0);
            TabToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            TabToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            CloseTabButton, BookmarkTabButton});
            TabToolStrip.Location = new System.Drawing.Point(3, 3);
            TabToolStrip.Name = "TabToolStrip";
            TabToolStrip.Padding = new Padding(5, 0, 5, 0);
            TabToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            TabToolStrip.Size = new Size(395, 40);
            TabToolStrip.MaximumSize = new Size(0, 30);
            TabToolStrip.Stretch = true;
            TabToolStrip.TabIndex = 0;
            TabToolStrip.BackColor = SystemColors.Window;
            TabToolStrip.Text = "";
            TabToolStrip.Cursor = Cursors.Default;
            TabToolStrip.Margin = new Padding(0);
            TabToolStrip.Dock = DockStyle.Top;

            CloseTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            CloseTabButton.Name = "CloseTabButton";
            CloseTabButton.Padding = new Padding(5);
            CloseTabButton.Margin = new Padding(0);
            CloseTabButton.Size = new Size(30, 40);
            CloseTabButton.Text = "Close";
            CloseTabButton.ForeColor = Color.Black;
            CloseTabButton.BackColor = Color.DarkSlateGray;
            CloseTabButton.ToolTipText = "Close this tab";
            CloseTabButton.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            CloseTabButton.BackColor = Color.LightGray;
            CloseTabButton.MouseEnter += new EventHandler(TabToolsButton_Enter);
            CloseTabButton.MouseLeave += new EventHandler(TabToolsButton_Leave);
            CloseTabButton.Click += new EventHandler(CloseTabButton_Click);

            BookmarkTabButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            BookmarkTabButton.Name = "BookmarkTabButton";
            BookmarkTabButton.Padding = new Padding(5);
            BookmarkTabButton.Margin = new Padding(0,0, 5, 0);
            BookmarkTabButton.Size = new Size(30, 40);
            BookmarkTabButton.Text = "Bookmark this page";
            BookmarkTabButton.ForeColor = Color.Black;
            BookmarkTabButton.BackColor = Color.DarkSlateGray;
            BookmarkTabButton.ToolTipText = "Bookmark this page";
            BookmarkTabButton.Font = new Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            BookmarkTabButton.BackColor = Color.LightGray;
            BookmarkTabButton.MouseEnter += new EventHandler(TabToolsButton_Enter);
            BookmarkTabButton.MouseLeave += new EventHandler(TabToolsButton_Leave);
            BookmarkTabButton.Click += new EventHandler(BookmarkTabButton_Click);

            return TabToolStrip;

        }

        private void BookmarkTabButton_Click(object sender, EventArgs e) {

            String title = WebsiteTabControl.SelectedTab.Text;
            String url = Browsr.Tabs.Items[Browsr.Tabs.FindKeyByTitle(title)].Url;

            new AddBookmark(Browsr.Bookmarks, title, url).ShowDialog();

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {

            // User pressed CTRL + ALT
            if(e.Control && e.Alt) {

                // Get the other key pressed e.g. CTRL + ALT + H
                switch(e.KeyCode) {


                    // History
                    case Keys.H:

                        ToggleSidebar(HistoryButton, e);

                        break;

                    // Bookmarks
                    case Keys.B:

                        ToggleSidebar(BookmarksButton, e);

                        break;

                    // Settings
                    case Keys.S:

                        OpenSettings();

                        break;

                }

                // User pressed CTRL
            } else if (e.Control) {

                // Get the other key pressed e.g. CTRL + T
                switch(e.KeyCode) {
                    
                    // New tab
                    case Keys.T:
                        AddTab();
                        break;

                    // Close tab
                    case Keys.W:
                        CloseTab();
                        break;

                    case Keys.Q:
                        Application.Exit();
                        break;

                    case Keys.Add:
                        float fsize = GetOutputArea(WebsiteTabControl.SelectedTab).Font.Size;
                        GetOutputArea(WebsiteTabControl.SelectedTab).Font = new Font(GetOutputArea(WebsiteTabControl.SelectedTab).Font.FontFamily, ++fsize);
                        break;

                    case Keys.Subtract:
                        fsize = GetOutputArea(WebsiteTabControl.SelectedTab).Font.Size;
                        GetOutputArea(WebsiteTabControl.SelectedTab).Font = new Font(GetOutputArea(WebsiteTabControl.SelectedTab).Font.FontFamily, --fsize);
                        break;

                }

            }

        }

        private void CloseTabButton_Click(object sender, EventArgs e) {

            CloseTab();

        }

        private void TabToolsButton_Enter(object sender, EventArgs e) {

            var button = (sender as ToolStripButton);

            button.BackColor = System.Drawing.Color.DarkGray;

            // Find the parent toolstrip menu; set the cursor
            (button.Owner as ToolStrip).Cursor = Cursors.Hand;

        }

        private void TabToolsButton_Leave(object sender, EventArgs e) {

            var button = (sender as ToolStripButton);

            button.BackColor = System.Drawing.Color.LightGray;

            // Find the parent toolstrip menu; set the cursor
            (button.Owner as ToolStrip).Cursor = Cursors.Default;

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {

            Browsr.Save();

        }

        private void SettingsButton_Click(object sender, EventArgs e) {

            OpenSettings();

        }

        private void TabHistoryTravel(bool forward) {

            // Get the current tab
            Tab tab = Browsr.Tabs.Items[Browsr.Tabs.FindKeyByTitle(WebsiteTabControl.SelectedTab.Text)];

            if(forward)
                tab.forward();
            else
                tab.back();
            
            WebsiteTabControl.SelectedTab.Text = tab.Title;
            OpenPage(WebsiteTabControl.SelectedTab, tab.Url);

        }

        private void BackButton_Click(object sender, EventArgs e) {
            TabHistoryTravel(false);
        }

        private void ForwardButton_Click(object sender, EventArgs e) {
            TabHistoryTravel(true);
        }
    }
}
