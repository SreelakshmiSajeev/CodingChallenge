
Console.WriteLine("Enter the passenger name:");
string name = Console.ReadLine();
Console.WriteLine("Enter the miles travelled:");
decimal miles = Convert.ToDecimal(Console.ReadLine());
decimal flyrepoint = 0;
if ((miles > 10_000)&&(miles < 20_000))
{
    flyrepoint = 10;
}
else if ((miles > 20_000) &&(miles < 50_000))
{
    flyrepoint = 20;
}
else if ((miles > 50_000)&& (miles < 100_000))
{
    flyrepoint = 30;
}
else 
{
    flyrepoint = 50;
}

Console.WriteLine(name+" "+"who has travelled "+" "+miles+" "+"has flyrepoint of"+" "+flyrepoint);