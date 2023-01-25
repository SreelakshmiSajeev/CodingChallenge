int n = 3;
DateTime[] dob = new DateTime[n];
DateTime prsentTime = DateTime.Now;
int[] ages = new int[n];

for (int i = 0;i < dob.Length; i++)
{
    Console.WriteLine("Enter the DOB:");
    dob[i] = Convert.ToDateTime(Console.ReadLine());
    ages[i]  = prsentTime.Year - dob[i].Year;
}
foreach (int age in ages)
{
    if(age>=0 && age < 10)
    {
        Console.WriteLine("kid");
    }
    else if (age >= 10 && age < 30)
    {
        Console.WriteLine("Youth");
    }
    else if (age >= 30 && age < 60)
    {
        Console.WriteLine("Adult");
    }
    else
    {
        Console.WriteLine("Old");
    }
}

