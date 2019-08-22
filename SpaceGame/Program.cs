using SpaceGameProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {
        //testsync
        static void Main(string[] args)
        {
            try
            {
                Matic m = new Matic();
                Init i = new Init();

                m.IntroCinematic();
                i.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
