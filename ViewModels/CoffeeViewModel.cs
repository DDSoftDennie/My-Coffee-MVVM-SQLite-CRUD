using MyCoffeeMVVMSQLite.Models;
using MyCoffeeMVVMSQLite.Services;
using System.Windows.Input;

namespace MyCoffeeMVVMSQLite.ViewModels;
// https://learn.microsoft.com/en-us/dotnet/maui/tutorials/notes-mvvm/?tutorial-step=5

public partial class CoffeeViewModel : BaseViewModel
{
	private string _vmTest = "";
	private CoffeeModel _coffee = new CoffeeModel();
	private List<CoffeeModel> _coffees = new List<CoffeeModel>();
	private InMemService _coffeeService;
	public ICommand TestCommand { get; private set; }
	public ICommand AddCoffee{ get; private set; }
	public ICommand LoadCoffees{ get; private set; }

	public string VMTest
	{
		get => _vmTest;
		set => SetProperty(ref _vmTest, value);
	}

	CoffeeViewModel()
	{
		_coffeeService = new InMemService();
		TestCommand = new Command(TestCode);
	}

	private void TestCode()
	{
		VMTest = "Hello World";

	}




}