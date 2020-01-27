using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Teacher : ITeacher
    {
        private string firstname;
        private string lastname;

        public Teacher(string firstname, string lastname)
        {
            Firstname = firstname ?? throw new ArgumentNullException(nameof(firstname));
            Lastname = lastname ?? throw new ArgumentNullException(nameof(lastname));
            TeacherID = "T-" + DateTime.Now.Ticks.ToString();
        }

        public string TeacherID { get; }

        public string Firstname { get => firstname; set => this.firstname = value; }
        public string Lastname { get => lastname; set => this.lastname = value; }

        public string Fullname => Firstname + " " + Lastname;

        override public string ToString()
        {
            return TeacherID + ": " + Fullname;
        }
    }
}
