using System;

namespace helloworld
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Random random = new System.Random();
      int answer = random.Next(101);
      int input = 0;
      string response = "guess the number between 1-100";
      while (input != answer)
      {
        Console.Clear();
        System.Console.WriteLine($"{response}");
        input = Convert.ToInt32(System.Console.ReadLine());
        if (input > answer)
        {
          response = "guess lower";
          continue;
        }
        if (input < answer)
        {
          response = "guess higher";
          continue;
        }
        System.Console.WriteLine("Thats Correct!");
        System.Console.WriteLine("You Win!");
      }
    }
  }
}
