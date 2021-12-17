using System;
using System.IO;

class Program {
  public static void Main(string[] args) {
    Format f  = new Format();

    /* Checking if file exists, 
    it's so janky and I do it twice which is probabaly not necesary.
    Need to get Help on this.*/

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
        int k = 1;

        while (j == 1) { // Checking to see if the users input is the pass and user. Then looping through that
          if (f.User() != null) {
            if (!f.User().Equals(Input)) { 
              Console.WriteLine("You are prompted to log in!");
              Console.Write("User: ");
              Input = Console.ReadLine();
            } else {
              Console.Write("Pass: ");
              Input = Console.ReadLine();
              while (k == 1) {
                if (f.Pass() != null) {
                  if (!f.Pass().Equals(Input)) { 
                    Console.Write("Pass: ");
                    Input = Console.ReadLine();
                  } else {
                    i = 0;
                    j = 0;
                    k = 0;
                  }
                }
              } 
            }
          }
        }

    } else {
      // All file writing stuff.
      Console.WriteLine("Please register a Username");

      Console.Write("User: ");
      Input = Console.ReadLine();
      using (StreamWriter sw = new StreamWriter("config.ucom", append: true)) {
          sw.WriteLine("User: " + Input);

          Console.Write("Pass: ");

          Input = Console.ReadLine();
          
          sw.WriteLine("Pass: " + Input);
          i = 0;
        }
      }
    } 

    Console.WriteLine("You are Logged in!");
    Input = Console.ReadLine();
  }
}