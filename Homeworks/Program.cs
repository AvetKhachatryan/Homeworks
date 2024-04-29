using System.IO;

string pathOut = @"C:\Users\avetx\Desktop\C##\example.txt";
string pathIn = @"C:\Users\avetx\Desktop\Folder\newpage.txt";
string line;
using (StreamReader sr = new StreamReader(pathOut))
{
    line = sr.ReadLine()!;
    while (line != null)
    {
        using (StreamWriter sw = new StreamWriter(pathIn, true))
        {
            sw.WriteLine(line);
        }
        line = sr.ReadLine()!;
    }
}