string[] a;
int count = 0; 
string s;

Console.Write("count = ");
count = Int32.Parse(Console.ReadLine());

a = new string[count];
Console.WriteLine();

for (int i=0; i<a.Length; i++)
    {
    Console.Write("a[{0}] = ", i);
    a[i] = Console.ReadLine();
    }

int stringsize = 4;

for (int i=0; i<a.Length; i++)
    {
    int strlength = a[i].Length;
    if (a[i].Length < stringsize) 
        Console.WriteLine (a[i]);
    }

