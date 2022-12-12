using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    internal class Student : Person
    {
        public override byte GetAge()
        {
            Console.WriteLine("student age");  
            return 0;
        }
        public override string GetFullname()
        {
            Console.WriteLine("student fullname");
            return "student fullname";
        }
    }
}
