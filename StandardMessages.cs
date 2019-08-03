using System;
namespace UserRegistrationApp
{
  public class StandardMessages
  {
    public static void greetingMessage()
    {
      Console.WriteLine("Welcome to my application");
    }

    public static void userInputError(string nameType)
    {
      Console.WriteLine($"You didn't give us a valid {nameType} name");
    }

    public static void endApplication()
    {
      Console.ReadLine();
    }
  }
}