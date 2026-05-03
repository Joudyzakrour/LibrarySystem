using System;
using LibrarySystem;


namespace LibrarySystem
{
    public class Magazine : LibraryItem
    {
        private int issueNumber;

        public int IssueNumber
        {
            get { return issueNumber; }
            set
            {
                if (value > 0)
                    issueNumber = value;
                else
                    Console.WriteLine("Invalid issue number");
            }
        }

        public Magazine(int id, string title, int issue) : base(id, title)
        {
            IssueNumber = issue;
        }

        public override void Displayinfo()
        {
            Console.WriteLine($"Magazine: {Title}, Issue: {IssueNumber}");
        }
    }
}