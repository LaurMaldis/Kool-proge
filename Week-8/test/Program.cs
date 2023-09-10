string path = @"D:\repos\Kool-proge\Week-8\test";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(path, fileName));
Console.WriteLine(lines.Length);