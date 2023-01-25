using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_one
{
    internal class Length
    {
        public void length(string[] names) {
            string names2 = " ";
            int l;
            for (int i = 0; i < names.Length; i++)
            {
                names2 = null;
                names2 = names[i];
                Console.WriteLine("length of"+" "+ names[i]+"  "+"is"+ " "+names2.Length);
            }
        }
    }
}
