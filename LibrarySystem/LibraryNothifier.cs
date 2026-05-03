using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class LibraryNothifier
    {
        public delegate void ItemAddedHandler(string message);
        public class LibraryNotifier
        {
            public event ItemAddedHandler OnItemAdded;
            public void AddItem(string itemName)
            {
                OnItemAdded?.Invoke($" New item added:{itemName}");

            }
        }
    }

}
