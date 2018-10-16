using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Stack
    {
        static void Main()
        {
            Stack<string> names = new Stack<string>();
            {
                names.Push("ravi");
                names.Push("ashu");
                names.Push("Puja");
                names.Push("shahil");
                

                foreach (string var in names)
                {
                    Console.WriteLine(var);
                }
                Console.WriteLine("Peek element:" + names.Peek());
                Console.WriteLine("Pop:" + names.Pop());
                Console.WriteLine("after Pop,Peek element:" + names.Peek());
                foreach (string var in names)
                {
                    Console.WriteLine(var);
                }



            }
            Console.ReadLine();
        }
    }
}
