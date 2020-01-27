using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class ModelFactory : IModelFactory
    {

        public IPerson CreateStudent(string Firstname, string Lastname)
        {
            return new Student(Firstname, Lastname);
        }

        public IPerson CreateTeacher(string Firstname, string Lastname)
        {
            return new Teacher(Firstname, Lastname);
        }
    }
}
