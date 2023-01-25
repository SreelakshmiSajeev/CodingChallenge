using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_one
{
    internal class Duplicate
    {
        public void duplicate(string[] names) {
    

          for(int i=0;i<names.Length;i++)

            {
                int c = 1;
                for (int j=i+1;j<names.Length;j++)
                {
                   
                    if(names[i].Equals(names[j])) {
                        
                        
                        Console.WriteLine("Duplicate element is:"+" "+names[i]);
                        c++;
                        Console.WriteLine(c);

                    }
                    
                }
            }
        }
    }
    }

