using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_one
{
    internal class Split
    {
        public void split(string[] names)
        {
            string names2 = " ";
            for (int i = 0; i < names.Length; i++)
            {
                names2 = null;
                names2 = names[i];
                string[] words = names2.Split(' ');

                foreach (var word in words)
                {
                    System.Console.WriteLine(" The splitted words are:" + word);
                }
            }
        }
    }
}
        
    

