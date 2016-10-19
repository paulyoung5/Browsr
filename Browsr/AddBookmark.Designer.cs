namespace Browsr {
    partial class AddBookmark {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookmark));
            this.AddFavouriteTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishAddFavButton = new System.Windows.Forms.Button();
            this.BodyFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ChooseTitleLabel = new System.Windows.Forms.Label();
            this.BookmarkTitle = new System.Windows.Forms.TextBox();
            this.FavouriteUrlLabel = new System.Windows.Forms.Label();
            this.BookmarkURL = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BookmarksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddFavouriteTableLayoutPanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.BodyFlowLayoutPanel.SuspendLayout();
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
            this.AddFavouriteTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AddFavouriteTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AddFavouriteTableLayoutPanel.Name = "AddFavouriteTableLayoutPanel";
            this.AddFavouriteTableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.AddFavouriteTableLayoutPanel.RowCount = 3;
            this.AddFavouriteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.97661F));
            this.AddFavouriteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.02339F));
            this.AddFavouriteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.AddFavouriteTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AddFavouriteTableLayoutPanel.Size = new System.Drawing.Size(314, 227);
            this.AddFavouriteTableLayoutPanel.TabIndex = 3;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.CancelButton);
            this.ActionsPanel.Controls.Add(this.FinishAddFavButton);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionsPanel.Location = new System.Drawing.Point(3, 176);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ActionsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ActionsPanel.Size = new System.Drawing.Size(308, 43);
            this.ActionsPanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CancelButton.Location = new System.Drawing.Point(10, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 33);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FinishAddFavButton
            // 
            this.FinishAddFavButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinishAddFavButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FinishAddFavButton.Location = new System.Drawing.Point(223, 5);
            this.FinishAddFavButton.Name = "FinishAddFavButton";
            this.FinishAddFavButton.Size = new System.Drawing.Size(75, 33);
            this.FinishAddFavButton.TabIndex = 0;
            this.FinishAddFavButton.Text = "Add";
            this.FinishAddFavButton.UseVisualStyleBackColor = true;
            this.FinishAddFavButton.Click += new System.EventHandler(this.FinishAddFavButton_Click);
            // 
            // BodyFlowLayoutPanel
            // 
            this.BodyFlowLayoutPanel.Controls.Add(this.ChooseTitleLabel);
            this.BodyFlowLayoutPanel.Controls.Add(this.BookmarkTitle);
            this.BodyFlowLayoutPanel.Controls.Add(this.FavouriteUrlLabel);
            this.BodyFlowLayoutPanel.Controls.Add(this.BookmarkURL);
            this.BodyFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyFlowLayoutPanel.Location = new System.Drawing.Point(3, 44);
            this.BodyFlowLayoutPanel.Name = "BodyFlowLayoutPanel";
            this.BodyFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.BodyFlowLayoutPanel.Size = new System.Drawing.Size(308, 126);
            this.BodyFlowLayoutPanel.TabIndex = 2;
            // 
            // ChooseTitleLabel
            // 
            this.ChooseTitleLabel.AutoSize = true;
            this.BodyFlowLayoutPanel.SetFlowBreak(this.ChooseTitleLabel, true);
            this.ChooseTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseTitleLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ChooseTitleLabel.Location = new System.Drawing.Point(15, 10);
            this.ChooseTitleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ChooseTitleLabel.Name = "ChooseTitleLabel";
            this.ChooseTitleLabel.Size = new System.Drawing.Size(93, 19);
            this.ChooseTitleLabel.TabIndex = 0;
            this.ChooseTitleLabel.Text = "Choose a title";
            // 
            // BookmarkTitle
            // 
            this.BookmarkTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BookmarkTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BodyFlowLayoutPanel.SetFlowBreak(this.BookmarkTitle, true);
            this.BookmarkTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookmarkTitle.Location = new System.Drawing.Point(10, 34);
            this.BookmarkTitle.Margin = new System.Windows.Forms.Padding(0);
            this.BookmarkTitle.Name = "BookmarkTitle";
            this.BookmarkTitle.Size = new System.Drawing.Size(288, 25);
            this.BookmarkTitle.TabIndex = 1;
            this.BookmarkTitle.TextChanged += new System.EventHandler(this.BookmarkTitle_TextChanged);
            // 
            // FavouriteUrlLabel
            // 
            this.FavouriteUrlLabel.AutoSize = true;
            this.BodyFlowLayoutPanel.SetFlowBreak(this.FavouriteUrlLabel, true);
            this.FavouriteUrlLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavouriteUrlLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.FavouriteUrlLabel.Location = new System.Drawing.Point(15, 69);
            this.FavouriteUrlLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.FavouriteUrlLabel.Name = "FavouriteUrlLabel";
            this.FavouriteUrlLabel.Size = new System.Drawing.Size(104, 19);
            this.FavouriteUrlLabel.TabIndex = 2;
            this.FavouriteUrlLabel.Text = "Is this url okay?";
            // 
            // BookmarkURL
            // 
            this.BookmarkURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BookmarkURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BodyFlowLayoutPanel.SetFlowBreak(this.BookmarkURL, true);
            this.BookmarkURL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookmarkURL.Location = new System.Drawing.Point(10, 93);
            this.BookmarkURL.Margin = new System.Windows.Forms.Padding(0);
            this.BookmarkURL.Name = "BookmarkURL";
            this.BookmarkURL.Size = new System.Drawing.Size(288, 25);
            this.BookmarkURL.TabIndex = 3;
            this.BookmarkURL.TextChanged += new System.EventHandler(this.BookmarkURL_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BookmarksButton);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(308, 35);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // BookmarksButton
            // 
            this.BookmarksButton.AccessibleName = "Bookmarks";
            this.BookmarksButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BookmarksButton.BackColor = System.Drawing.Color.Transparent;
            this.BookmarksButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BookmarksButton.BackgroundImage")));
            this.BookmarksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BookmarksButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.BookmarksButton.Enabled = false;
            this.BookmarksButton.FlatAppearance.BorderSize = 0;
            this.BookmarksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BookmarksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BookmarksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookmarksButton.Location = new System.Drawing.Point(10, 10);
            this.BookmarksButton.Margin = new System.Windows.Forms.Padding(10);
            this.BookmarksButton.Name = "BookmarksButton";
            this.BookmarksButton.Size = new System.Drawing.Size(18, 18);
            this.BookmarksButton.TabIndex = 11;
            this.BookmarksButton.UseVisualStyleBackColor = false;
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
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add to bookmarks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddBookmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(316, 226);
            this.ControlBox = false;
            this.Controls.Add(this.AddFavouriteTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBookmark";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.AddFavouriteTableLayoutPanel.ResumeLayout(false);
            this.ActionsPanel.ResumeLayout(false);
            this.BodyFlowLayoutPanel.ResumeLayout(false);
            this.BodyFlowLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AddFavouriteTableLayoutPanel;
        private System.Windows.Forms.Panel ActionsPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishAddFavButton;
        private System.Windows.Forms.FlowLayoutPanel BodyFlowLayoutPanel;
        private System.Windows.Forms.Label ChooseTitleLabel;
        private System.Windows.Forms.TextBox BookmarkTitle;
        private System.Windows.Forms.Label FavouriteUrlLabel;
        private System.Windows.Forms.TextBox BookmarkURL;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BookmarksButton;
        private System.Windows.Forms.Label label1;
    }
}