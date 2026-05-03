using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book:LibraryItem
    {
        public string Author { get; set; }
        public Book (int id , string title,string author) : base( id ,title)
        {
            Author = author;
        }
        public override void Displayinfo()
        {
            Console.WriteLine( $" Book :{ Title},Author :{ Author}");
        }

    }
}
