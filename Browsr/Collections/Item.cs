using System;
using System.Collections.Generic;

namespace Browsr {

    /// <summary>
    /// Item
    /// Intended for use as Tabs, History/Bookmarks items, etc
    /// </summary>
    public class Item {

        // Item's title, i.e. "Google"
        private String title;
        public String Title {

            get {

                return title;

            }

            set {

                title = value;

            }

        }

        // Item's associated url
        private String url;
        public String Url {

            get {
                return url;
            }

            set {
                url = value;
            }

        }

        public Item(String title, String url) {

            Title = title;
            Url = url;

        }

    }

}
