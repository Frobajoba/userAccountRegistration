using System;
namespace UserRegistrationApp
{
  class GatherDetails
  {
    public static Person firstName(Person user)
    {
      Console.WriteLine("What is your first name?");
      user.firstName = Console.ReadLine();
      return user;
    }
    public static Person lastName(Person user)
    {
      Console.WriteLine("What is your first name?");
      user.lastName = Console.ReadLine();
      return user;
    }
  }
}