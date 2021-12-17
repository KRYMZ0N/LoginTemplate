using System;
using System.IO;

public class Format {

  
  StreamReader sr = new StreamReader("config.ucom");
  string user = ReadSpecificLine("config.ucom", 1);

  public string User() { // scrapping the user in the string
    String i = user.Replace("User: ", "");
    return i;
  }

  public static string ReadSpecificLine(string filePath, int lineNumber) { // finds specific line in a file
    string content = null;
    try
    {
        using (StreamReader file = new StreamReader(filePath))
        {
            for (int i = 1; i < lineNumber; i++)
            {
                file.ReadLine();
 
                if (file.EndOfStream) {
                    Console.WriteLine($"End of file.  The file only contains {i} lines.");
                    break;
                }
            }
            content = file.ReadLine();
        }
 
    }
    catch (IOException e)
    {
        Console.WriteLine("There was an error reading the file: ");
        Console.WriteLine(e.Message);
    }
 
    return content;
  }
}