 System.IO.StreamReader reader = null;

try
{
    string line;
    int counter = 0;
    string path = @"C:\Users\jotha\OneDrive\Escritorio\holamundo.txt";

    reader = new System.IO.StreamReader(path);

    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
        counter++;  
    }
}
catch
{
    Console.WriteLine("Connection Error");
}
finally
{
    if ((reader != null)) reader.Close();
    Console.WriteLine("Connection finished");
}