﻿using System;

namespace UserRegistrationApp
{
  class Program
  {
    static void Main(string[] args)
    {
      StandardMessages.greetingMessage();
      Person user = new Person();
      Console.WriteLine("What is your first name?");
      user.firstName = Console.ReadLine();

      if (string.IsNullOrWhiteSpace(user.firstName))
      {
        StandardMessages.userInputError("first");
        StandardMessages.endApplication();
        return;
      }

      Console.WriteLine("What is your last name?");
      user.lastName = Console.ReadLine();

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
