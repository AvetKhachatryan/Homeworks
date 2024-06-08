
string path = @"C:\Users\avetx\Desktop\data.txt";

int Balance;
using (StreamReader sr = new StreamReader(path))
{
    string line = sr.ReadLine();
    int balance = int.Parse(line);
    Balance = balance;
}

Console.WriteLine("Mnacordi stugum: 1");
Console.WriteLine("Gumari mutqagrum: 2");
Console.WriteLine("Gumari stacum: 3");
Console.WriteLine("Tvyalner: 4");
int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1:
        using (StreamReader sr = new StreamReader(path))
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        break;
    case 2:
        Console.Write("Gumari qanaky: ");
        int Rep = int.Parse(Console.ReadLine());
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine(Balance + Rep);
            sw.WriteLine("Avet\nXachatryan");
        }
        Console.WriteLine("Gumary mutqagrvac e");
        break;
    case 3:
        Console.Write("Gumari qanaky: ");
        int change = int.Parse(Console.ReadLine());
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine(Balance - change);
            sw.WriteLine("Avet\nXachatryan");
        }
        Console.WriteLine("Gumary stacvac e");
        break;
    case 4:
        Console.WriteLine("Tvyalnery: ");
        using (StreamReader sr = new StreamReader(path))
        {
            string line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
        }
        break;
}
