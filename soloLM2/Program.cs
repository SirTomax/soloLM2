using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soloLM2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                // Get x
                Console.Write("x = ");
                string str = Console.ReadLine();
                
                // Exit?
                if (str == "exit")
                    break;

                // Convert x
                int x = Convert.ToInt32(str);
                
                // Get y
                Console.Write("y = ");
                int y = Convert.ToInt32(Console.ReadLine());
                
                // calculate sum
                int sum = x + y;
                Console.WriteLine("Result: {0}", sum);
            }
            while (true); // repeat
        }
    }
}
