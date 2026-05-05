using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
        public delegate void ItemAddedHandler(string message);
        public class LibraryNotifier //edit
        {
            public event ItemAddedHandler OnItemAdded;
            public void AddItem(string itemName)
            {
                OnItemAdded?.Invoke($" New item added:{itemName}");

            }
        }
    }


