using System;
using System.Windows.Forms;

namespace Browsr {
    public partial class AddBookmark : Form {

        private String _title;
        private String _url;

        public String Title {
            get {
                return _title;
            }
            set {
                _title = value;
            }
        }
        public String Url {
            get {
                return _url;
            }
            set {
                _url = value;
            }
        }

        private ItemManager<Item> Bookmarks;

        public AddBookmark(ItemManager<Item> bookmarks, string title, string url) {
            InitializeComponent();

            BookmarkTitle.Text = title;
            BookmarkURL.Text = url;

            this.Bookmarks = bookmarks;

        }

        public void HideForm(object sender, EventArgs e) {

            (sender as Button).FindForm().Hide();

        }

        private void CancelButton_Click(object sender, EventArgs e) {

            HideForm(sender, e);
        }

        private void FinishAddFavButton_Click(object sender, EventArgs e) {

            Bookmarks.AddItem(new Item(Title, Url));

            HideForm(sender, e);

        }

        private void BookmarkTitle_TextChanged(object sender, EventArgs e) {
            Title = (sender as TextBox).Text;
        }

        private void BookmarkURL_TextChanged(object sender, EventArgs e) {
            Url = (sender as TextBox).Text;
        }
    }
}
