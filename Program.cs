string file;
string destinationfile;
Console.WriteLine("please enter file location :");
file = Console.ReadLine();
Console.WriteLine("please enter destinationfile :");
destinationfile  = Console.ReadLine();
try
{
    File.Copy(file, destinationfile, true);
}
catch (IOException iox)
{
    Console.WriteLine(iox.Message);
}
foreach(file in Directory.GetFiles(destinationfile))
{
    if (File.Exists(file))
    {
        Console.WriteLine("file is exists");
    }
}