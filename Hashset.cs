using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Hash
    {
        static void Main()
        {
            var name = new HashSet<string>();

            {
                name.Add("ravi");
                name.Add("ashu");
                name.Add("Puja");
                name.Add("shahil");
                name.Add("shahil");
                foreach (var naam in name) 
                {
                    Console.WriteLine(naam);

                }
                Console.ReadLine();

            }
        }
    }
}
