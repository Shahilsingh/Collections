using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Linked
    {
        static void Main()
        {
            var names = new LinkedList<string>();
            names.AddLast("ravi");
            names.AddLast("ashu");
            names.AddLast("shahil");
            names.AddFirst("puja");

            foreach(var dd in names)
            {
                Console.WriteLine(dd);
            }
            Console.ReadLine();

        }
    }
}
