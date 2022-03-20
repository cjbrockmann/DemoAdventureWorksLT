using DemoAdventureWorks.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppAdventureWorksLT.ViewModels;

namespace WpfAppAdventureWorksLT.Commands
{
    internal class UpdateViewCommand : ICommand
    {


        private MainVM viewModel;

        Dictionary<string, BaseViewModel> dict = new Dictionary<string, BaseViewModel>();


        public UpdateViewCommand(MainVM viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {

            var param = parameter?.ToString();

            
            if (!string.IsNullOrEmpty(param)) {
                if (!dict.ContainsKey(param))
                {
                    if (param == "Products") dict.Add(param, new ProductCollectionVM());
                    if (param == "Addresses") dict.Add(param, new AddressCollectionVM());
                    if (param == "Customers") dict.Add(param, new CustomerCollectionVM());
                }

                if (dict.ContainsKey(param)) viewModel.SelectedViewModel = dict[param];
                else viewModel.SelectedViewModel = null;
            }
            else
            {
                viewModel.SelectedViewModel = null;
            }

        }
    }
}
