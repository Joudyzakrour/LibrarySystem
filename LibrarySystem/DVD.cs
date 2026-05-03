using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class DVD : LibraryItem
    {
        private int duration;

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value > 0)
                    duration = value;
                else
                    Console.WriteLine("Invalid duration!");
            }
        }

        public DVD(int id, string title, int duration)
            : base(id, title)
        {
            Duration = duration;
        }

        public override void Displayinfo()
        {
            Console.WriteLine($"DVD: {Title}, Duration: {Duration} mins");
        }
    }
}