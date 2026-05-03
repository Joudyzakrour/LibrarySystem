using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Library
    {
        private List<LibraryItem> items = new List<LibraryItem>();

        public List<LibraryItem> Items
        {
            get { return items; }
        }

        public void AddItem(LibraryItem item)
        {
            items.Add(item);
        }

        public void ShowAllItems()
        {
            foreach (var item in items)
            {
                item.Displayinfo();
            }
        }

        public void Search(string title)
        {
            foreach (var item in items)
            {
                if (item.Title.ToLower().Contains(title.ToLower()))
                {
                    item.Displayinfo();
                }
            }
        }
        public void RemoveItem( int id )
        {
            items.RemoveAll(x => x.Id == id);
        }
    }
}