using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_one
{
    internal class Sort
    {
        public void sort(string[] names)
        {
            Array.Sort(names);

            Console.WriteLine("After sorting:"+" "+String.Join(", ", names));
        }
    }
}
