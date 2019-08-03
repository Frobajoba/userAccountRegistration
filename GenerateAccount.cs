using System;
namespace UserRegistrationApp
{
  class GenerateAccount
  {
    public static void create(string first, string last)
    {
      Console.WriteLine($"Your username is {first.Substring(0, 1)}{last}");
    }
  }
}