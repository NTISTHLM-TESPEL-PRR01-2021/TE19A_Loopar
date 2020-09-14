using System;

namespace Loopar
{
  class Program
  {
    static void Main(string[] args)
    {
      
      int y = 40;

      string name = "";
      string password = "";

      //  || (name == "herbert" && password == "123")

      while (!(name == "micke" && password == "sallad") && !(name == "herbert" && password == "123"))
      {
        System.Console.WriteLine("Skriv in ditt namn: ");
        name = Console.ReadLine();

        System.Console.WriteLine("Skriv in ditt lösenord: ");
        password = Console.ReadLine();

        // System.Console.WriteLine(y);
        // y--;
      }

      System.Console.WriteLine("VÄLKOMMEN");

      Console.ReadLine();
    }
  }
}
