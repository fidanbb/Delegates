using System;
using Delegate.Models;

namespace Delegate
{
	public class Delegates
	{

		public void FilterBySalary(List<Person> people, Predicate<decimal> func)
		{

			foreach (var person in people)
			{
				if (func(person.Salary))
				{
					Console.WriteLine($" {person.Name} - {person.Surname} - {person.Address} - {person.Salary}");
				}
			}
		}

        public void CountByAuthor(List<Book> books, Predicate<string> func)
        {
			int count = 0;

            foreach (var book in books)
            {
                if (func(book.Author.Trim().ToLower()))
                {
					count++;
                }
            }

			Console.WriteLine(count);
        }
    }
}

