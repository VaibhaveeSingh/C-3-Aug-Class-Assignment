using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Strings
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter First String atleast 5 character long");
            string strOne = Console.ReadLine();
            Console.WriteLine("Enter Second String atleast 5 character long");
            string strTwo = Console.ReadLine();
            Console.WriteLine("1. Concatenate Strings. \n2. Lengths of two String. \n3. Substring. \n4. Replace \n5. Upper case \n6. Lowercase \n7. Trim \n8. Split \nMake the choice again or Enter 9 to exit");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine(string.Concat(strOne,strTwo));
                    break;
                case 2:
                    Console.WriteLine("length of First string is {0} and second string is {1}",strOne.Length, strTwo.Length);
                    break;
                case 3:
                    Console.WriteLine("substring removing from string 1 from index 2");
                    Console.WriteLine(strOne.Remove(2));
                    Console.WriteLine("substring removing from string 2 from index 2 to 4");
                    Console.WriteLine(strTwo.Remove(2,4));
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine(strOne.ToUpper());
                    Console.WriteLine(strTwo.ToUpper());
                    break;
                case 6:
                    Console.WriteLine(strOne.ToLower());
                    Console.WriteLine(strTwo.ToLower());
                    break;
                case 7:
                    char[] trim = { ' ' };
                    Console.WriteLine("trimming all spaces");
                    Console.WriteLine(strOne.Trim(trim));
                    Console.WriteLine(strTwo.Trim(trim));
                    break;
                case 8:
                    string str = string.Concat(strOne, strTwo);
                    string[] splitStr= str.Split(' ');
                    Console.WriteLine("spliting every word");
                    foreach (var S in splitStr)
                    {
                        Console.WriteLine(S);
                    }
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("press valid key");
                    break;
            }
            Console.Read();  
        }
    }
}
