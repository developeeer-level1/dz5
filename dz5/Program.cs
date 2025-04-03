using System;
using System.Linq;

namespace dz5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            try
            {
                Money m1 = new Money(10, 50);
                Money m2 = new Money(5, 25);

                Console.WriteLine("First number: " + m1);
                Console.WriteLine("Another number: " + m2);
                Console.WriteLine("Amount: " + (m1 + m2));
                Console.WriteLine("Retail: " + (m1 - m2));
                Console.WriteLine("Multiply by 2: " + (m1 * 2));
                Console.WriteLine("Division by 2: " + (m1 / 2));
                Console.WriteLine("Increase by 1 copy: " + (++m1));
                Console.WriteLine("Change by 1 copy: " + (--m2));
                Console.WriteLine("Is one better than another? " + (m1 > m2));
                Console.WriteLine("Is one better than the other? " + (m1 < m2));
                Console.WriteLine("What are the regions?" + (m1 == m2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request: " + ex.Message);
            }
            Console.ReadLine();
        }
    }

}