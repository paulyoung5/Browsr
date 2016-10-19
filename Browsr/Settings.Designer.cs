namespace Browsr {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.AddFavouriteTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SettingsImageList = new System.Windows.Forms.ImageList(this.components);
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.BodyFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GeneralSettingsTabPage = new System.Windows.Forms.TabPage();
            this.GeneralSettingsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OpeningConfigsLabel = new System.Windows.Forms.Label();
            this.OpenHomepageRadioButton = new System.Windows.Forms.RadioButton();
            this.OpenBlankRadioButton = new System.Windows.Forms.RadioButton();
            this.HomepageLabel = new System.Windows.Forms.Label();
            this.HomepageUrlTextBox = new System.Windows.Forms.TextBox();
            this.MiscSettingsTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearHistoryButton = new System.Windows.Forms.Button();
            this.DeleteBookmarksButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SettingsIcon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddFavouriteTableLayoutPanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.BodyFlowLayoutPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GeneralSettingsTabPage.SuspendLayout();
            this.GeneralSettingsFlowLayoutPanel.SuspendLayout();
            this.MiscSettingsTabPage.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFavouriteTableLayoutPanel
            // 
            this.AddFavouriteTableLayoutPanel.ColumnCount = 1;
            this.AddFavouriteTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddFavouriteTableLayoutPanel.Controls.Add(this.ActionsPanel, 0, 2);
            this.AddFavouriteTableLayoutPanel.Controls.Add(this.BodyFlowLayoutPanel, 0, 1);
            this.AddFavouriteTableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.AddFavouriteTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddFavouriteTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AddFavouriteTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AddFavouriteTableLayoutPanel.Name = "AddFavouriteTableLayoutPanel";
            this.AddFavouriteTableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.AddFavouriteTableLayoutPanel.RowCount = 3;
            this.AddFavouriteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.25424F));
            this.AddFavouriteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.74577F));
            this.AddFavouriteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.AddFavouriteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AddFavouriteTableLayoutPanel.Size = new System.Drawing.Size(562, 349);
            this.AddFavouriteTableLayoutPanel.TabIndex = 5;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.CancelButton);
            this.ActionsPanel.Controls.Add(this.SaveSettingsButton);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionsPanel.Location = new System.Drawing.Point(3, 298);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ActionsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ActionsPanel.Size = new System.Drawing.Size(556, 43);
            this.ActionsPanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.ImageKey = "Cancel";
            this.CancelButton.ImageList = this.SettingsImageList;
            this.CancelButton.Location = new System.Drawing.Point(10, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Padding = new System.Windows.Forms.Padding(5);
            this.CancelButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelButton.Size = new System.Drawing.Size(80, 33);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SettingsImageList
            // 
            this.SettingsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SettingsImageList.ImageStream")));
            this.SettingsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.SettingsImageList.Images.SetKeyName(0, "Cancel");
            this.SettingsImageList.Images.SetKeyName(1, "Save");
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveSettingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveSettingsButton.ImageKey = "Save";
            this.SaveSettingsButton.ImageList = this.SettingsImageList;
            this.SaveSettingsButton.Location = new System.Drawing.Point(466, 5);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Padding = new System.Windows.Forms.Padding(5);
            this.SaveSettingsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveSettingsButton.Size = new System.Drawing.Size(80, 33);
            this.SaveSettingsButton.TabIndex = 0;
            this.SaveSettingsButton.Text = "Save";
            this.SaveSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // BodyFlowLayoutPanel
            // 
            this.BodyFlowLayoutPanel.Controls.Add(this.SettingsPanel);
            this.BodyFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyFlowLayoutPanel.Location = new System.Drawing.Point(3, 48);
            this.BodyFlowLayoutPanel.Name = "BodyFlowLayoutPanel";
            this.BodyFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.BodyFlowLayoutPanel.Size = new System.Drawing.Size(556, 244);
            this.BodyFlowLayoutPanel.TabIndex = 2;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsPanel.Controls.Add(this.tabControl1);
            this.SettingsPanel.Location = new System.Drawing.Point(13, 8);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(532, 236);
            this.SettingsPanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GeneralSettingsTabPage);
            this.tabControl1.Controls.Add(this.MiscSettingsTabPage);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(5, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 233);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // GeneralSettingsTabPage
            // 
            this.GeneralSettingsTabPage.Controls.Add(this.GeneralSettingsFlowLayoutPanel);
            this.GeneralSettingsTabPage.Location = new System.Drawing.Point(4, 26);
            this.GeneralSettingsTabPage.Name = "GeneralSettingsTabPage";
            this.GeneralSettingsTabPage.Padding = new System.Windows.Forms.Padding(10);
            this.GeneralSettingsTabPage.Size = new System.Drawing.Size(524, 203);
            this.GeneralSettingsTabPage.TabIndex = 0;
            this.GeneralSettingsTabPage.Text = "General";
            this.GeneralSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // GeneralSettingsFlowLayoutPanel
            // 
            this.GeneralSettingsFlowLayoutPanel.Controls.Add(this.OpeningConfigsLabel);
            this.GeneralSettingsFlowLayoutPanel.Controls.Add(this.OpenHomepageRadioButton);
            this.GeneralSettingsFlowLayoutPanel.Controls.Add(this.OpenBlankRadioButton);
            this.GeneralSettingsFlowLayoutPanel.Controls.Add(this.HomepageLabel);
            this.GeneralSettingsFlowLayoutPanel.Controls.Add(this.HomepageUrlTextBox);
            this.GeneralSettingsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralSettingsFlowLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.GeneralSettingsFlowLayoutPanel.Name = "GeneralSettingsFlowLayoutPanel";
            this.GeneralSettingsFlowLayoutPanel.Size = new System.Drawing.Size(504, 183);
            this.GeneralSettingsFlowLayoutPanel.TabIndex = 0;
            // 
            // OpeningConfigsLabel
            // 
            this.OpeningConfigsLabel.AutoSize = true;
            this.GeneralSettingsFlowLayoutPanel.SetFlowBreak(this.OpeningConfigsLabel, true);
            this.OpeningConfigsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpeningConfigsLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.OpeningConfigsLabel.Location = new System.Drawing.Point(5, 5);
            this.OpeningConfigsLabel.Margin = new System.Windows.Forms.Padding(5);
            this.OpeningConfigsLabel.Name = "OpeningConfigsLabel";
            this.OpeningConfigsLabel.Size = new System.Drawing.Size(134, 19);
            this.OpeningConfigsLabel.TabIndex = 2;
            this.OpeningConfigsLabel.Text = "When I open Browsr";
            // 
            // OpenHomepageRadioButton
            // 
            this.OpenHomepageRadioButton.AutoSize = true;
            this.OpenHomepageRadioButton.Location = new System.Drawing.Point(3, 32);
            this.OpenHomepageRadioButton.Name = "OpenHomepageRadioButton";
            this.OpenHomepageRadioButton.Size = new System.Drawing.Size(120, 17);
            this.OpenHomepageRadioButton.TabIndex = 3;
            this.OpenHomepageRadioButton.TabStop = true;
            this.OpenHomepageRadioButton.Text = "Open my homepage";
            this.OpenHomepageRadioButton.UseVisualStyleBackColor = true;
            this.OpenHomepageRadioButton.CheckedChanged += new System.EventHandler(this.OpenHomepageRadioButton_CheckedChanged);
            // 
            // OpenBlankRadioButton
            // 
            this.OpenBlankRadioButton.AutoSize = true;
            this.GeneralSettingsFlowLayoutPanel.SetFlowBreak(this.OpenBlankRadioButton, true);
            this.OpenBlankRadioButton.Location = new System.Drawing.Point(129, 32);
            this.OpenBlankRadioButton.Name = "OpenBlankRadioButton";
            this.OpenBlankRadioButton.Size = new System.Drawing.Size(98, 17);
            this.OpenBlankRadioButton.TabIndex = 4;
            this.OpenBlankRadioButton.TabStop = true;
            this.OpenBlankRadioButton.Text = "Open blank tab";
            this.OpenBlankRadioButton.UseVisualStyleBackColor = true;
            // 
            // HomepageLabel
            // 
            this.HomepageLabel.AutoSize = true;
            this.GeneralSettingsFlowLayoutPanel.SetFlowBreak(this.HomepageLabel, true);
            this.HomepageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomepageLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.HomepageLabel.Location = new System.Drawing.Point(5, 57);
            this.HomepageLabel.Margin = new System.Windows.Forms.Padding(5);
            this.HomepageLabel.Name = "HomepageLabel";
            this.HomepageLabel.Size = new System.Drawing.Size(105, 19);
            this.HomepageLabel.TabIndex = 5;
            this.HomepageLabel.Text = "Homepage URL";
            // 
            // HomepageUrlTextBox
            // 
            this.HomepageUrlTextBox.Location = new System.Drawing.Point(3, 84);
            this.HomepageUrlTextBox.Name = "HomepageUrlTextBox";
            this.HomepageUrlTextBox.Size = new System.Drawing.Size(296, 20);
            this.HomepageUrlTextBox.TabIndex = 6;
            this.HomepageUrlTextBox.TextChanged += new System.EventHandler(this.HomepageUrlTextBox_TextChanged);
            // 
            // MiscSettingsTabPage
            // 
            this.MiscSettingsTabPage.Controls.Add(this.flowLayoutPanel2);
            this.MiscSettingsTabPage.Location = new System.Drawing.Point(4, 26);
            this.MiscSettingsTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.MiscSettingsTabPage.Name = "MiscSettingsTabPage";
            this.MiscSettingsTabPage.Padding = new System.Windows.Forms.Padding(10);
            this.MiscSettingsTabPage.Size = new System.Drawing.Size(524, 203);
            this.MiscSettingsTabPage.TabIndex = 1;
            this.MiscSettingsTabPage.Text = "Browsing Data";
            this.MiscSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.ClearHistoryButton);
            this.flowLayoutPanel2.Controls.Add(this.DeleteBookmarksButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(504, 183);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.flowLayoutPanel2.SetFlowBreak(this.label2, true);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage your browsing data";
            // 
            // ClearHistoryButton
            // 
            this.ClearHistoryButton.Location = new System.Drawing.Point(3, 41);
            this.ClearHistoryButton.Name = "ClearHistoryButton";
            this.ClearHistoryButton.Size = new System.Drawing.Size(92, 32);
            this.ClearHistoryButton.TabIndex = 3;
            this.ClearHistoryButton.Text = "Clear History";
            this.ClearHistoryButton.UseVisualStyleBackColor = true;
            this.ClearHistoryButton.Click += new System.EventHandler(this.ClearHistoryButton_Click);
            // 
            // DeleteBookmarksButton
            // 
            this.DeleteBookmarksButton.Location = new System.Drawing.Point(101, 41);
            this.DeleteBookmarksButton.Name = "DeleteBookmarksButton";
            this.DeleteBookmarksButton.Size = new System.Drawing.Size(121, 32);
            this.DeleteBookmarksButton.TabIndex = 4;
            this.DeleteBookmarksButton.Text = "Delete Bookmarks";
            this.DeleteBookmarksButton.UseVisualStyleBackColor = true;
            this.DeleteBookmarksButton.Click += new System.EventHandler(this.DeleteBookmarksButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SettingsIcon);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(556, 39);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // SettingsIcon
            // 
            this.SettingsIcon.AccessibleName = "Bookmarks";
            this.SettingsIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SettingsIcon.BackColor = System.Drawing.Color.Transparent;
            this.SettingsIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsIcon.BackgroundImage")));
            this.SettingsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingsIcon.Enabled = false;
            this.SettingsIcon.FlatAppearance.BorderSize = 0;
            this.SettingsIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SettingsIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SettingsIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsIcon.Location = new System.Drawing.Point(10, 10);
            this.SettingsIcon.Margin = new System.Windows.Forms.Padding(10);
            this.SettingsIcon.Name = "SettingsIcon";
            this.SettingsIcon.Size = new System.Drawing.Size(18, 18);
            this.SettingsIcon.TabIndex = 11;
            this.SettingsIcon.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(41, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(562, 349);
            this.Controls.Add(this.AddFavouriteTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.AddFavouriteTableLayoutPanel.ResumeLayout(false);
            this.ActionsPanel.ResumeLayout(false);
            this.BodyFlowLayoutPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.GeneralSettingsTabPage.ResumeLayout(false);
            this.GeneralSettingsFlowLayoutPanel.ResumeLayout(false);
            this.GeneralSettingsFlowLayoutPanel.PerformLayout();
            this.MiscSettingsTabPage.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AddFavouriteTableLayoutPanel;
        private System.Windows.Forms.Panel ActionsPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ImageList SettingsImageList;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.FlowLayoutPanel BodyFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SettingsIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GeneralSettingsTabPage;
        private System.Windows.Forms.FlowLayoutPanel GeneralSettingsFlowLayoutPanel;
        private System.Windows.Forms.Label OpeningConfigsLabel;
        private System.Windows.Forms.RadioButton OpenHomepageRadioButton;
        private System.Windows.Forms.RadioButton OpenBlankRadioButton;
        private System.Windows.Forms.TabPage MiscSettingsTabPage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HomepageLabel;
        private System.Windows.Forms.TextBox HomepageUrlTextBox;
        private System.Windows.Forms.Button ClearHistoryButton;
        private System.Windows.Forms.Button DeleteBookmarksButton;
    }
}