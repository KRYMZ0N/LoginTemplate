using System;
using System.IO;

class Program {
  public static void Main(string[] args) {

    if (File.Exists("config.ucom")) {
      Console.WriteLine("You are prompted to log in!");

      Console.Write("User: ");
    } else {
      Console.WriteLine("Please register a Username");
      Console.Write("User: ");
    }

    String Input = Console.ReadLine();
    int i = 1;

    while (i == 1) {
      
      if (File.Exists("config.ucom")) {

        StreamReader sr = new StreamReader("config.ucom");

        String line = sr.ReadLine();
        int j = 1;
        while (j == 1) {    
          if (line != null) {
            if (!line.Contains(Input)) { 
              Console.WriteLine("You are prompted to log in!");
              Console.Write("User: ");
              Input = Console.ReadLine();
            } else {
              j = 0;
              i = 0;
            }
          }
        }

    } else {
      Console.WriteLine("Please register a Username");

      Console.Write("User: ");
      Input = Console.ReadLine();
      using (StreamWriter sw = new StreamWriter("config.ucom"))
        {
          sw.WriteLine("User: " + Input);
          i = 0;
        }
      }
    } 

    Console.WriteLine("Hello user");
    Input = Console.ReadLine();
  }
}