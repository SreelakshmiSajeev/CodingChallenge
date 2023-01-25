using System;

decimal[] decimals = new decimal[5];
Console.WriteLine("Enter the flight fares:");
for (int i = 0;i < decimals.Length; i++)
{
    decimals[i] = Convert.ToDecimal(Console.ReadLine());
}
Console.WriteLine("The flight fares are:");
for(int i = 0; i < decimals.Length; i++)
{
    Console.WriteLine(decimals[i]);
}
for(int i=0;i< decimals.Length;i++)
    for(int j=0;j< decimals.Length;j++)
        if (decimals[i] < decimals[j])
        {
            decimal temp = decimals[i];
            decimals[i] = decimals[j];
            decimals[j] = temp;
        }
Console.WriteLine("After sorting in asscending order:");
for(int i=0;i< decimals.Length; i++)
{
    Console.WriteLine(decimals[i]);
}
Console.WriteLine("---------------------------------------------------------------------------");
for (int i = 0; i < decimals.Length; i++)
    for (int j = 0; j < decimals.Length; j++)
        if (decimals[i] > decimals[j])
        {
            decimal temp = decimals[i];
            decimals[i] = decimals[j];
            decimals[j] = temp;
        }
Console.WriteLine("After sorting in desscending order:");
for (int i = 0; i < decimals.Length; i++)
{
    Console.WriteLine(decimals[i]);
}

Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("Enter the fare to searched");
decimal n = Convert.ToDecimal(Console.ReadLine());
int Count = 0;
decimal teamp = 0;
for(int i = 0; i < decimals.Length; i++)
{
    if (decimals[i]==n) {

        Count++;   
         teamp = decimals[i];
    }

}
if(Count == 0)
{
    Console.WriteLine("not found");
}
else
    Console.WriteLine( "search is successfull"+" "+teamp );

Console.WriteLine("---------------------------------------------------------------------------");
decimal max = decimals[0];

for (int i = 1; i < decimals.Length; i++)
    if (max < decimals[i])
    {
        max = decimals[i];
    }

Console.WriteLine("Maximum value is:" + " " + max);






Console.WriteLine("---------------------------------------------------------------------------");
decimal min = decimals[0];

for (int i = 1; i < decimals.Length; i++)
    if (min > decimals[i])
    {
        min = decimals[i];
    }
Console.WriteLine("Minimum value is:" + " " + min);


Console.WriteLine("---------------------------------------------------------------------------");
decimal counter = 0;
for (int i = 0; i < decimals.Length; i++)
    for(int j=i+1;j<decimals.Length;j++)
{
    if (decimals[i] == decimals[j])
        {
            
           
            counter++;
            Console.WriteLine("Duplicated element is" + " " + counter);
        }
    
}
if (counter == 0)
{
    Console.WriteLine("no duplicate elements");
    
}