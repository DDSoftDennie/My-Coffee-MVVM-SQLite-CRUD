using MyCoffeeMVVMSQLite.Models;

namespace MyCoffeeMVVMSQLite.Services
{
    public interface ICoffeeService
    {
        List<CoffeeModel> GetAllCoffees();
        Task AddCoffee(string name, string roaster);
        Task<IEnumerable<CoffeeModel>> GetCoffee();
        Task<CoffeeModel> GetCoffee(int id);
        Task RemoveCoffee(int id);


    }
}
