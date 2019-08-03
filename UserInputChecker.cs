using System;
namespace UserRegistrationApp
{
  class UserInputChecker
  {
    public static void firstName(String first)
    {
      if (string.IsNullOrWhiteSpace(first))
      {
        StandardMessages.userInputError("first");
        StandardMessages.endApplication();
      }
    }

    public static void lastName(String last)
    {
      if (string.IsNullOrWhiteSpace(last))
      {
        StandardMessages.userInputError("last");
        StandardMessages.endApplication();
      }
    }


  }
}