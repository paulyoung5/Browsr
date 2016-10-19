using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browsr {
    public class Tab : Item {

        private Stack<Item> _prev;
        private Stack<Item> _next;

        public Stack<Item> Prev {

            get {
                return _prev;
            }

            set {
                _prev = value;
            }

        }
        public Stack<Item> Next {

            get {
                return _next;
            }

            set {
                _next = value;
            }

        }

        public Tab(String title, String url, int tabControlIndex) : base(title, url) {

            Title = title;
            Url = url;

            Prev = new Stack<Item>();
            Next = new Stack<Item>();

        }

        public void Update(String title, String url) {

            Prev.Push(new Item(Title, Url));

            Title = title;
            Url = url;

        }

        public bool hasPrev() {

            return Prev.Count > 0;

        }

        public bool hasNext() {

            return Next.Count > 0;

        }

        public void forward() {

            if(hasNext()) {

                Prev.Push(new Item(Title, Url));

                Item current = Next.Pop();
                Title = current.Title;
                Url = current.Url;

            }

        }

        public void back() {

            if(hasPrev()) {

                Next.Push(new Item(Title, Url));

                Item current = Prev.Pop();
                Title = current.Title;
                Url = current.Url;

            }

        }

    }
}
