using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonesOrNoBones
{
    class Program
    {
        static void Main(string[] args)
        {
            /// instanciates new object for random
            Random rnd = new Random();

            ///sets array 
            string[] Day = { "It's a Bones Day", "It's a No Bones Day" };

            //random selects from Day string array
            int index = rnd.Next(Day.Length);
            Console.WriteLine(Day[index]);



            Console.ReadKey();


        }
    }
}
