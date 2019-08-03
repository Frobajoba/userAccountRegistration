using System;

namespace UserRegistrationApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to my application");
      Person user = new Person();
      Console.WriteLine("What is your first name?");
      user.firstName = Console.ReadLine();
      Console.WriteLine("What is your last name?");
      user.lastName = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(user.firstName))
      {
        Console.WriteLine("You didn't give us a valid first name");
        Console.ReadLine();
        return;
      }

      if (string.IsNullOrWhiteSpace(user.lastName))
      {
        Console.WriteLine("You didn't give us a valid last name");
        Console.ReadLine();
        return;
      }

      Console.WriteLine($"Your username is {user.firstName.Substring(0, 1)}{user.lastName}");
      Console.ReadLine();

    }
  }
}
