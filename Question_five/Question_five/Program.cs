
Console.WriteLine("Enter the size of array");
int total = Convert.ToInt32(Console.ReadLine());

decimal fare;

decimal[] array = new decimal[total*2];

int even = 0;
int odd = 1;

for (int i = 0; i < total*2; i++)
{
    Console.WriteLine("Enter Fares: ");
    fare = Convert.ToDecimal(Console.ReadLine());
   if(fare % 2 == 0)
    {
        array[even] = fare;
        even +=2;
    }
    else
    {
        array[odd] = fare;
        odd +=2;
    }
}
Console.WriteLine(" flight fares after arranging are:");
for (int i = 0; i < total*2; i++)
{
    Console.WriteLine(array[i]);
}
