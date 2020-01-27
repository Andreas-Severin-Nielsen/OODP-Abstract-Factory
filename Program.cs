using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new ModelFactory());
            client.CreateAndWriteNames();
            Console.ReadKey();
        }
    }
}
