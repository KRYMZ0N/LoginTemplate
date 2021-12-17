using System;
using System.IO;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("");

    if (File.Exists("config.ucom")) {
      Console.WriteLine("You are prompted to log in!");
      Console.Write("User: ");
    } else {
      Console.WriteLine("Please register a Username");
      Console.Write("User: ");
    }

    int i = 1;
    String Input = Console.ReadLine();

    while (i > 0) {
      using (StreamWriter sw = new StreamWriter("config.ucom"))
        {
          sw.WriteLine(Input);
          i = 0;
    }
  }
  }
}