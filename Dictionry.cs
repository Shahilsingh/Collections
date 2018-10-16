using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Dictionry
    {
        static void Main()
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            {
                names.Add("1", "Ravi");
                names.Add("2", "Ravi");
                names.Add("3", "Ravi");
                names.Add("4", "Ravi");

                foreach (var kv in names)
                {
                    Console.WriteLine(kv.Key + "" + kv.Value);
                }
                Console.ReadLine();

            }



        }
    }
}
