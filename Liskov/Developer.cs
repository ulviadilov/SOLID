using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    internal class Developer : Person , IExperience
    {
        public override byte GetAge()
        {
            Console.WriteLine("developer age : ");
            return 30;
        }

        public byte GetExperience()
        {
            Console.WriteLine("developer experience : ");
            return 7;
        }

        public override string GetFullname()
        {
            return "developer fullname";
        }
    }
}
