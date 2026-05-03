using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public static class Validator
    {
        public static bool IsValidTitle(string title)
        {
           
               return !string.IsNullOrWhiteSpace(title);
        }
    }
}
