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
      GenerateAccount.create(user.firstName, user.lastName);
      StandardMessages.endApplication();
    }
  }
}