using DAL;
using Domain;
using System;
using System.Collections.Generic;

// Homework

// Ability to add ContactType 

// Main menu
//   - Persons (crud)
//   - Contact Types (crud)
//   - Exit

namespace ContactBook
{
  class Program
  {
    private static void ListPeople(List<Person> people)
    {
      foreach (var person in people)
      {
        int _num = people.IndexOf(person) + 1;
        Console.WriteLine($"{_num}. {person}");
      }
    }

    static void Main(string[] args)
    {
      var ctx = new Context();

      ConsoleKeyInfo input;

      Console.WriteLine("------------------");
      Console.WriteLine("| Sup phone book |");
      Console.WriteLine("------------------");

      do
      {
        Console.WriteLine("List all contacts");
        Console.WriteLine("Add contact");
        Console.WriteLine("Delete contact");
        Console.WriteLine("Exit");
        input = Console.ReadKey();
        Console.WriteLine("\r\n");

        switch (input.KeyChar.ToString().ToLower())
        {
          case "l":
            ListPeople(ctx.People);
            break;
          case "a":
            Console.WriteLine("First name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Last name:");
            var lastName = Console.ReadLine();
            ctx.People.Add(new Person() { FirstName = firstName, LastName = lastName });
            break;
          case "d":
            ListPeople(ctx.People);
            Console.WriteLine();
            Console.WriteLine("Select a person by number to delete");
            int _personId = 0;
            try
            {
              string inputNum = Console.ReadKey().KeyChar.ToString();
              Int32.TryParse(inputNum, out _personId);
              ctx.People.RemoveAt(_personId - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
              Console.WriteLine("Wrong ID provided!");
            }
            break;
          default:
            break;
        }
      } while (input.KeyChar.ToString().ToLower() != "e" && input.KeyChar.ToString().ToLower() != "x");
    }
  }
}
