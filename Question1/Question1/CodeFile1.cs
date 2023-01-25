using System.Xml.Linq;
string[] names = new string[4];
string name = "sree";
Console.WriteLine("enter the element");
for (int i = 0; i < names.Length; i++)
{
    names[i] = Console.ReadLine();

}
Console.WriteLine("new array is:");
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
for (int i = 0; i < names.Length; i++)
    if (names[i] == name)
    {
        Console.WriteLine("name is found" + name);
        break;
    }

