FilesManagement fileReaded = new FilesManagement();


class FilesManagement
{
    System.IO.StreamReader file = null;
    private int _counter = 0;
    private string _line = "Null";
    private string _path = @"C:\Users\jotha\OneDrive\Escritorio\holamundo.txt";

    public FilesManagement ()
    {
        try
        {
            file = new System.IO.StreamReader(_path);

            while ((_line = file.ReadLine()) != null)
            {
                Console.WriteLine(_line);
            }

            _counter++;
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }

    public void message ()
    {
        Console.WriteLine($"There are {_counter} lines in the file");
    }

    ~FilesManagement()
    {
        file.Close();
    }

}
