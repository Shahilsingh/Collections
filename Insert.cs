using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Insert
    {
        static void Main()
        {
            var names = new LinkedList<string>();
            names.AddLast("ankit");
            names.AddLast("Raju");
            names.AddLast("Ram");
            names.AddLast("Ashu");
            LinkedListNode<string> node = names.Find("Ram");
            names.AddBefore(node,"Ram");
            names.AddAfter (node,"Ram");
            foreach (var dock in names)
            {
                Console.WriteLine(dock);
            }
            Console.ReadLine();
        }
    }
}
