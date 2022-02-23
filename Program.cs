using System;
using System.IO;
using System.Threading.Tasks;

namespace Recipes
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Would you like to flip 1 coin 100 times?");
      string ans = Console.ReadLine();
      if(ans == "Yes")
      {
          for (int counter = 1; counter <= 101; counter ++)
          {
              Flipping();

          }
      }
      else
      {
          Console.WriteLine("Fuck Off");
      }
      Console.ReadKey();

    }
    static void Flipping()
    {
        string filepath = @".\Documents\Coin.txt";
        Random num = new Random();
        int put = num.Next(1, 3);
        Console.WriteLine(put);
        if (put == 1)
        {
        for (int i = 1; i < 2; i++)
        {
            using(StreamWriter sw = File.AppendText(filepath))
        {
            sw.WriteLine(i);
        }
        }
        
        
    }
}     
}
        }
