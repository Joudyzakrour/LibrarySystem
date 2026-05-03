using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public abstract class LibraryItem : IBorrowble
    {
        private int id;
        public int Id { get { return id; } }

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (Validator.IsValidTitle(value))
                    title = value;
                else
                    Console.WriteLine("Invalid title!");
            }
        }

        public LibraryItem(int id, string title)
        {
            this.id = id;
            Title = title;
        }

        public abstract void Displayinfo();

        public void Borrow()
        {
            Console.WriteLine("Item borrowed");
        }

        public void Return()
        {
            Console.WriteLine("Item returned");
        }
    }
}
