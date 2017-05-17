using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happyBapp1
{
    public class Friends
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string State { get; set; }

        public Friends(string fname, string lname, DateTime birthdate, string email, string state)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Birthdate = birthdate;
            this.Email = email;
            this.State = state;
        }
        public Friends() { }
    }
}
