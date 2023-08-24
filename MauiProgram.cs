﻿namespace MyCoffeeMVVMSQLite;
using MyCoffeeMVVMSQLite.ViewModels;
using MyCoffeeMVVMSQLite.Views;
using MyCoffeeMVVMSQLite.Services;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});



        // Service Registration 
        builder.Services.AddSingleton<ICoffeeService, SQLiteCoffeeService>();

        // View Registration
        builder.Services.AddSingleton<MainPage>(); 
        builder.Services.AddSingleton<CoffeeView>();

        // View Model Registration
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<CoffeeViewModel>();


        return builder.Build();
	}
}
