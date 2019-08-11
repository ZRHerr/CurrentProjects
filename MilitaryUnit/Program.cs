using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            string branchName = Console.ReadLine();
            int region = int.Parse(Console.ReadLine());
            int personnelCount = int.Parse(Console.ReadLine());
            try
            {
                Marines marines = new Marines(branchName, region, personnelCount);
                Console.WriteLine(marines);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
