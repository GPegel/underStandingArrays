using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace underStandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is one kind of way to play with arrays
            //int[] numbers = new int[] { 4, 8, 16, 32, 48 };
            //Console.WriteLine(numbers[1].ToString());
            //Console.ReadLine();

            //This is another kind of way to play with variable arrays
            //string[] names = new string[] { "gerhard", "susan", "daan", "tesfay", "barry" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //This is another kind way to play with very long string arrays in a char
            //ech indinvidual letter will be an element of the char array
            //The "Reverse" method of the Array class will 'reverse' the sentence
            string zig = "This is what happens when you put in a very looooooooong" +
                            "string to this tiny console";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
                Console.WriteLine(zigChar);
            Console.ReadLine();
        }
    }
}
