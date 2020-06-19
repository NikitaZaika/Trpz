using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using TRPZ.User_Interface;
using BusinessLogic.Abstract;
using BusinessLogic.Implementation;
using BusinessLogic.Implementation.Classes;

namespace TRPZ
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    
    public partial class App : Application
    {   
        private readonly ServiceProvider serviceProvider;
        public App()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindow, MainWindow>();
            services.AddTransient<IModel, Model>();
            services.AddTransient<ViewModel, ViewModel>();
            services.AddTransient<IStorageNetwork, StorageNetwork>();
            services.AddTransient<DataLoader, DataLoader>();
            services.AddTransient<OrderCreator, OrderCreator>();

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            ViewModel viewModel = serviceProvider.GetService<ViewModel>();
            new MainWindow { DataContext = viewModel };
            MainWindow.Show();
        }
    }
}
