using System;
using System.Windows.Forms;

namespace Browsr {
    public partial class Settings : Form {

        private Browsr _browsr;

        public Settings(Browsr Browsr) {

            InitializeComponent();

            _browsr = Browsr;

            if((bool) _browsr.Settings["ShowHomepage"])
                OpenHomepageRadioButton.Checked = true;
            else
                OpenBlankRadioButton.Checked = true;

            HomepageUrlTextBox.Text = (_browsr.Settings["Homepage"] as Item).Url;

        }

        public void HideForm(object sender, EventArgs e) {

            (sender as Button).FindForm().Hide();

        }

        private void CancelButton_Click(object sender, EventArgs e) {
            HideForm(sender, e);
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e) {
            HideForm(sender, e);
        }

        private String GetBasicTitle(String url) {

            try {
                return new Uri(url).Host;
            } catch {
                return url;
            }

        }

        private void OpeningConfigsLabel_Click(object sender, EventArgs e) {

        }

        private void HomepageUrlTextBox_TextChanged(object sender, EventArgs e) {

            var homepage = (_browsr.Settings["Homepage"] as Item);
            homepage.Url = (sender as TextBox).Text;
            homepage.Title = GetBasicTitle((sender as TextBox).Text);

        }

        private void OpenHomepageRadioButton_CheckedChanged(object sender, EventArgs e) {
            if((sender as RadioButton).Checked)
                _browsr.Settings["ShowHomepage"] = true;
            else
                _browsr.Settings["ShowHomepage"] = false;
        }

        private void ClearHistoryButton_Click(object sender, EventArgs e) {

            _browsr.History.Items.Clear();

        }

        private void DeleteBookmarksButton_Click(object sender, EventArgs e) {

            _browsr.Bookmarks.Items.Clear();

        }
    }
}
