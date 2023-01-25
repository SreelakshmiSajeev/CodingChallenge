using System.Xml.Linq;
string[] names = new string[4];
string name = string.Empty;
Console.WriteLine("Enter the Element");
for (int i = 0; i < names.Length; i++)
{
    names[i] = Console.ReadLine();

}
Console.WriteLine("New Array is:");
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
Console.WriteLine("Sorted Array is:");
for (int i = 0; i < names.Length; i++)
    for (int j = i + 1; j < names.Length; j++)
        if (names[i] > names[j])
        {
            name = names[i];
            names[i] = names[j];
            names[j] = name;
        }
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
