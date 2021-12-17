using System;
using System.IO;

class Program {
  public static void Main(string[] args) {
    Format f  = new Format();

    if (File.Exists("config.ucom")) {
      Console.WriteLine("You are prompted to log in!");

      Console.Write("User: ");
    } else {
      Console.WriteLine("Press Enter!");
      Console.Write("Login>> ");

    }

    String Input = Console.ReadLine();
    int i = 1;

    while (i == 1) {
      
      if (File.Exists("config.ucom")) {

        StreamReader sr = new StreamReader("config.ucom");

        int j = 1;
        while (j == 1) {
          if (f.User() != null) {
            if (!f.User().Equals(Input)) { 
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
      using (StreamWriter sw = new StreamWriter("config.ucom", append: true))
        {
          sw.WriteLine("User: " + Input);

          Console.Write("Pass: ");

          Input = Console.ReadLine();
          
          sw.WriteLine("Pass: " + Input);
          i = 0;
        }
      }
    } 

    Console.WriteLine("Hello user");
    Input = Console.ReadLine();
  }
}