
Console.WriteLine("Enter the flight fare:");
double f = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Enter the booking time As per Railway time:");
int t = Convert.ToInt32(Console.ReadLine());


if ((t >= 6) && (t < 9))
    {
    Console.WriteLine("Since the time you entered is in between 6 am And 9am ");
      f = f + f * .10;
      Console.WriteLine("Flight fare after 10 % increment:" + " " + f);
    }
      else if ((t >= 9) && (t < 17))
        {
         Console.WriteLine("Since the time you entered is in between 9 am And 5pm ");
         f = f + f * .20;
            Console.WriteLine("Flight fare after 20 % increment:" + " " + f);
        }
           else if((t >= 17) && (t<23))
              {
                Console.WriteLine("Since the time you entered is in between 5pm And 11pm ");
                f = f + f * .07;
                Console.WriteLine("Flight fare after 7 % increment:" + " " + f);
            }
                else 
                  {
                    Console.WriteLine("Since the time you entered is in between 11pm And 6am ");
                    f = f + f * .05;
                    Console.WriteLine("Flight fare after 5 % increment:" + " " + f);
                }
                    