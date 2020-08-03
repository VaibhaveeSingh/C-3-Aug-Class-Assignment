using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleAnimal
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] MyArray = new string[5];
            MyArray[0] = "Zebra";
            MyArray[1] = "Ant";
            MyArray[2] = "Owl";
            MyArray[3] = "Lion";
            

            Console.WriteLine("Using For Loop");
            for (int i = 0; i <=4 ; i++)
            {
                Console.WriteLine(MyArray[i]);
            }

            Console.WriteLine("using foreach");

            foreach (var i in MyArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("using do while");
            int x = 0;
            do
            {
                Console.WriteLine(MyArray[x]);
                x++;
            } while (x <5);

            Console.WriteLine("using while loop");
            int y = 0;
            while (y<5)
            {
                Console.WriteLine(MyArray[y]);
                y++;
            }

            Console.WriteLine("sorted array");

            Array.Sort(MyArray);

            foreach (var d in MyArray)
            {
                Console.WriteLine(d);
            }

            string[] animals = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };

            string[] places = { "Africa", "New Zealand", "Jamaica", "India" };

            Console.WriteLine("animals array before sorting");

            foreach (var a in animals)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("animals array after sorting");

            Array.Sort(animals);

            foreach (var A in animals)
            {
                Console.WriteLine(A);
            }


            Console.WriteLine("places array before sorting");

            foreach (var p in places)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("places array after sorting");

            Array.Sort(places);

            foreach (var P in places)
            {
                Console.WriteLine(P);
            }



        }
}
}
