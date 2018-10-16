using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Intadd
    {
        static void Main()
        {
            var Id = new List<int>();
            {
                Id.Add(50);
                Id.Add(40);
                Id.Add(30);
                Id.Add(20);
                foreach (var Idno in Id)
                {
                    Console.WriteLine(Idno);
                }
                Console.ReadLine();

            }
        }

    }
}
