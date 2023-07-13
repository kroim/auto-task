using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programming
{
    public class Contact
    {
        public Contact(string first, string last, string email)
        {
            this.First = first;
            this.Last = last;
            this.Email = email;
        }

        public string First
        {
            get;
            set;
        }
        public string Last
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
    }
}
