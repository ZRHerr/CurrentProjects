using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
        //Creating 2 complex objects that represent complex values (10 + 4i) and (5 + 2i)
        static void doWork()
        {
            Complex first = new Complex(10, 4);
            Complex second = new Complex(5, 2);

            Console.WriteLine($"first is {first}");
            Console.WriteLine($"second is {second}");

            Complex temp = first + second;
            Console.WriteLine($"Add: result is {temp}");

            temp = first - second;
            Console.WriteLine($"Subtract: result is {temp}");

            temp = first * second;
            Console.WriteLine($"Multiply: result is {temp}");

            temp = first / second;
            Console.WriteLine($"Divide: result is {temp}");

            if (temp == first)
            {
                Console.WriteLine("Comparison: temp == first");
            }
            else
            {
                Console.WriteLine("Comparison: temp != first");
            }
            //Intentional Comparison to verify that the == operator is working as expected
            if (temp == temp)
            {
                Console.WriteLine("Comparison: temp == temp");
            }
            else
            {
                Console.WriteLine("Comparison: temp != temp");
            }

            Console.WriteLine($"Current value of temp is {temp}");

            if (temp == 2)
            {
                Console.WriteLine("Comparison after conversion: temp == 2");
            }
            else
            {
                Console.WriteLine("Comparison after conversion: temp != 2");
            }

            temp += 2;
            Console.WriteLine($"Value after adding 2: temp = {temp}");

            int tempInt = (int)temp;
            Console.WriteLine($"Int value after conversion: tempInt == {tempInt}");
        }
    }
}
