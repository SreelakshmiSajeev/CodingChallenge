decimal[] fare = new decimal[5];
Console.WriteLine("Enter the fare in decimals:");
for(int i = 0;i < fare.Length; i++)
{
    fare[i] = Convert.ToDecimal(Console.ReadLine());
}
string[] destination= new string[5];
Console.WriteLine("Enter the destination:");
for (int i = 0; i < destination.Length; i++)
{
    destination[i] = Console.ReadLine();
}
Console.WriteLine("Enter any nth value in which the destination includes that you want to print:");
int value = Convert.ToInt32(Console.ReadLine());
for(int i = 0;i<fare.Length; i++)
{
    if(value == i)
    {
        Console.WriteLine("fare is:"+" " + fare[i]);
        break;
    }
}
for (int i = 0; i < destination.Length; i++)
{
    if (value == i)
    {
        Console.WriteLine("destination  is:" + " " + destination[i]);
        break;
    }
}