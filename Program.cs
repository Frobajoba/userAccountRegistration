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

      if (string.IsNullOrWhiteSpace(user.firstName))
      {
        StandardMessages.userInputError("first");
        StandardMessages.endApplication();
        return;
      }

      GatherDetails.lastName(user);

      if (string.IsNullOrWhiteSpace(user.lastName))
      {
        StandardMessages.userInputError("last");
        StandardMessages.endApplication();
        return;
      }



      Console.WriteLine($"Your username is {user.firstName.Substring(0, 1)}{user.lastName}");
      StandardMessages.endApplication();

    }
  }
}
