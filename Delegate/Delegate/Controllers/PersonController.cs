using System;
namespace Delegate.Controllers
{
	public class PersonController
	{
        private readonly Delegates _delegate;

        public PersonController()
        {
            _delegate = new Delegates();
        }

        public void FilterBySalary()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { Id = 1, Name = "Fidan", Surname = "Bashirova", Address = "Hazi", Salary = 3000 });
            people.Add(new Person() { Id = 2, Name = "Nigar", Surname = "Ehedli", Address = "Neftciler", Salary = 800 });
            people.Add(new Person() { Id = 3, Name = "Ehed", Surname = "Novruzov", Address = "Dernegul", Salary = 900 });
            people.Add(new Person() { Id = 4, Name = "Novruz", Surname = "Aliyev", Address = "Koroglu", Salary = 1500 });
            people.Add(new Person() { Id = 5, Name = "Zeynab", Surname = "Mehdiyeva", Address = "28May", Salary = 700 });

            decimal salary = 1000;

            _delegate.FilterBySalary(people, m => m > salary);

        }
    }
}

