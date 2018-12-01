using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[10];
            foreach (var score in scores)
            {
                Console.WriteLine($"Someone had this score : {score}");
            }
            Console.ReadKey();
            
        }
    }
}
