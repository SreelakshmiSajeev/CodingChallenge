
Console.WriteLine("Enter your date of birth:");
DateTime dob = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Your DOB is: " + " " + dob);
Console.WriteLine("-------------------------------------------------------------");


DateTime prsentTime = DateTime.Now;
TimeSpan age = prsentTime- dob;
Console.WriteLine("Your age is :" + " " + age);
Console.WriteLine("-------------------------------------------------------------");



Console.WriteLine("Your age in  hours:" + " " );
Console.WriteLine(age.Days*24);
Console.WriteLine("-------------------------------------------------------------");




Console.WriteLine("Your age in weeks :" + " ");
Console.WriteLine(age.Days / 7);
Console.WriteLine("-------------------------------------------------------------");



Console.WriteLine("Your age in years :" + " ");
Console.WriteLine(age.Days / 365);
Console.WriteLine("-------------------------------------------------------------");



if(dob.Year % 4 == 0)
{
    Console.WriteLine("It is a leap year");

}
else
{
    Console.WriteLine("Not aleap year");
}