using hm8;


class FileSeeker
{
    static void Main(string[] args)
    {
        try
        {
            string path = @"C:\c#projects\repo\c#homeworks\hm8\hm8\test\";

            Console.WriteLine("Searching .cs files...");
            var csFiles = Directory.EnumerateFiles(path, "*.cs", SearchOption.AllDirectories);

            foreach (string file in csFiles)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine();

            Console.WriteLine("Searching for text in files...");

            string searchText = "Main";

            foreach (string file in csFiles)
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(searchText))
                        {
                            Console.WriteLine($"Text {searchText} found in file: {file}");
                            break;
                        }
                    }
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
