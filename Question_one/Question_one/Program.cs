// See https://aka.ms/new-console-template for more information
using Question_one;
//Reverse obj = new Reverse();
//Search obj1 = new Search();
//Length obj2 = new Length();
//Split obj3 = new Split();
//Duplicate obj4 = new Duplicate();
Sort obj5 = new Sort();
string[] names = new string[6];


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

//obj.reverse(names);
//obj1.search(names);
//obj2.length(names); 
//obj3.split(names);
//obj4.duplicate(names);
obj5.sort(names);
