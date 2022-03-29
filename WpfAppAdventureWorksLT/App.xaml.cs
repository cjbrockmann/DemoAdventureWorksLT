using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DemoAdventureWorks.DAL.Core;
using DemoAdventureWorks.DAL.Context;
using System.IO;

namespace WpfAppAdventureWorksLT
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //public IServiceProvider serviceProvider { get; private set; }
        //public IConfiguration configuration { get; private set; }


        //public App()
        //{

        //    ServiceCollection services = new ServiceCollection();
        //    ConfigureServices(services);
        //    serviceProvider = services.BuildServiceProvider();

        //}

        //private void ConfigureServices(ServiceCollection services)
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json", false, true);

        //    configuration = builder.Build();

        //    services.AddDbContext<AdventureWorksLT2014Context>(options =>
        //    {
        //        options.UseSqlServer(configuration.GetConnectionString("Standard")); 
        //    });

            

        //    services.AddSingleton<IUnitOfWork, UnitOfWork>(); 

        //    services.AddSingleton<MainWindow>();
        //}


        //protected override void OnStartup(StartupEventArgs eventArgs)
        //{
        //    base.OnStartup(eventArgs);

        //    var mainWindow = serviceProvider.GetService<MainWindow>();
        //    mainWindow.Show();

        //}


    }
}
