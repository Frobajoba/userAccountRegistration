using System;
namespace UserRegistrationApp
{
  class UserInputChecker
  {
    public static void firstName(String firstName)
    {
      if (string.IsNullOrWhiteSpace(firstName))
      {
        StandardMessages.userInputError("first");
        StandardMessages.endApplication();
      }
    }

    public static void lastName(String lastName)
    {
      if (string.IsNullOrWhiteSpace(lastName))
      {
        StandardMessages.userInputError("last");
        StandardMessages.endApplication();
      }
    }


  }
}