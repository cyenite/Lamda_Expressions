using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_e
{
    class Program
    {
        static void Main(string[] args)
        {

            var names = new List<string>();

            for (int a = 0; a < 100; a++)
            {
           
                names.Add("Name" + a);
            }

            var result = names.Where(w => (w.EndsWith("2")));
           

            foreach (var item in result)
            {
                Console.WriteLine(item);
                //lists all items in result
            }

            Console.ReadKey();



        }
    }
}
