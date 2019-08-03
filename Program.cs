using System;

namespace UserRegistrationApp
{
  class Program
  {
    static void Main(string[] args)
    {
      StandardMessages.greetingMessage();
      Person user = new Person();
      GatherDetails.firstName(user);
      UserInputChecker.firstName(user.firstName);
      GatherDetails.lastName(user);
      UserInputChecker.lastName(user.lastName);

      Console.WriteLine($"Your username is {user.firstName.Substring(0, 1)}{user.lastName}");
      StandardMessages.endApplication();

    }
  }
}
