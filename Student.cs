using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Student : IStudent
    {
        private string firstname;
        private string lastname;

        public Student(string firstname, string lastname)
        {
            Firstname = firstname ?? throw new ArgumentNullException(nameof(firstname));
            Lastname = lastname ?? throw new ArgumentNullException(nameof(lastname));
            this.StudentID = "S-" + DateTime.Now.Ticks.ToString();
        }

        public string StudentID { get; }

        public string Firstname { get => firstname; set => this.firstname = value; }
        public string Lastname { get => lastname; set => this.lastname = value; }

        public string Fullname => Firstname + " " + Lastname;

        override public string ToString()
        {
            return StudentID + ": " + Fullname;
        }
    }
}
