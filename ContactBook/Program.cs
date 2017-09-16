using DAL;
using Domain;
using System;

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
		static void Main(string[] args)
		{
			var ctx = new Context();

			ConsoleKeyInfo input;

			do
			{
				Console.WriteLine("Sup phone book");
				Console.WriteLine("--------------");
				Console.WriteLine("List all contacts");
				Console.WriteLine("Add contact");
				Console.WriteLine("Delete contact");
				Console.WriteLine("Exit");
				input = Console.ReadKey();
				Console.WriteLine();

				switch (input.KeyChar.ToString().ToLower())
				{
					case "l":
						foreach (var person in ctx.Persons)
						{
							Console.WriteLine(person);
						}
						break;
					case "a":
						Console.WriteLine("\r\nFirst name:");
						var firstName = Console.ReadLine();
						Console.WriteLine("\r\nLast name:");
						var lastName = Console.ReadLine();
						ctx.Persons.Add(new Person() { FirstName = firstName, LastName = lastName });
						break;
					default:
						break;
				}
			} while (input.KeyChar.ToString().ToLower() != "e" && input.KeyChar.ToString().ToLower() != "x");
		}
	}
}
