using MyCoffeeMVVMSQLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeeMVVMSQLite.Services
{
	internal class InMemService : ICoffeeService
	{
		private readonly List<CoffeeModel> _coffees = new List<CoffeeModel>
		{
			new CoffeeModel() { Id = 1, Name = "Cappuccino", Roaster = "Starbucks" },
			new CoffeeModel() { Id = 2, Name = "Cafe au Lait", Roaster = "Costa" },
			new CoffeeModel() { Id = 3, Name = "Americano", Roaster = "Nero" },
			new CoffeeModel() { Id = 4, Name = "Espresso", Roaster = "Greggs" },
			new CoffeeModel() { Id = 5, Name = "Macchiato", Roaster = "Starbucks" }
		};

		

		public Task AddCoffee(string name, string roaster)
		{
			CoffeeModel coffee = new CoffeeModel { Name = name, Roaster = roaster };
			_coffees.Add(coffee);
			return Task.CompletedTask;
		}

		public Task<IEnumerable<CoffeeModel>> GetCoffee()
		{
			throw new NotImplementedException();
		}

		public Task<CoffeeModel> GetCoffee(int id)
		{
			throw new NotImplementedException();
		}

		public List<CoffeeModel> GetAllCoffees()
		{
			return _coffees.ToList();
		}

		public Task RemoveCoffee(int id)
		{
			throw new NotImplementedException();
		}
	}
}
