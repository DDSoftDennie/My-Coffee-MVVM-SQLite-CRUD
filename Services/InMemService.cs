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
		public Task AddCoffee(string name, string roaster)
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<CoffeeModel>> GetCoffee()
		{
			throw new NotImplementedException();
		}

		public Task<CoffeeModel> GetCoffee(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<CoffeeModel>> GetCoffeeList()
		{
			throw new NotImplementedException();
		}

		public Task RemoveCoffee(int id)
		{
			throw new NotImplementedException();
		}
	}
}
