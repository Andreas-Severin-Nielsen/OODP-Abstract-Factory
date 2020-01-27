using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Client
    {
        IModelFactory factory;
        List<IPerson> persons;

        public Client(IModelFactory factory)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
            persons = new List<IPerson>();
        }

        public void CreateAndWriteNames()
        {
            persons.Add(factory.CreateStudent("Patty", "O’Furniture"));
            persons.Add(factory.CreateStudent("Percy", "Vere"));
            persons.Add(factory.CreateTeacher("Mal", "Nurrisht"));
            persons.Add(factory.CreateStudent("Liz", "Erd"));

            foreach(IPerson p in persons)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
