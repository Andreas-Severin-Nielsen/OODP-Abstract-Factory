using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    interface IPerson
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Fullname { get;}
        
        string ToString();
    }
}
