using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_one
{
    internal class Search
    {
        public  void search(string[] names) {
            Console.WriteLine("Enter the string to be searched:");
            string s = Console.ReadLine();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] ==s)
                {
                    Console.WriteLine("Search is Sucessfull.Searched element is " + " " +  s );
                    break;
                }
                else
                {
                    Console.WriteLine("Search is unsucessful");
                    break;
                }
            }
        }
    }
}
