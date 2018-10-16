using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Queue
    {
        static void Main()
        {
            Queue<string> names = new Queue<string>();
            {
                names.Enqueue("ravi");
                names.Enqueue("ashu");
                names.Enqueue("shahil");
                names.Enqueue("Puja");

                foreach(string enter in names)
                {
                    Console.WriteLine(enter);
                }
                   Console.WriteLine("Peek element:" +names.Peek());
                   Console.WriteLine("Dequeue element:" + names.Dequeue());
                   Console.WriteLine("after Dequeue,Peek element:" +names.Peek());

            }
            Console.ReadLine();
        }
    }
}
