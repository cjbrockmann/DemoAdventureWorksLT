using DemoAdventureWorks.DAL.Context;
using DemoAdventureWorks.DAL.Core;
using DemoAdventureWorks.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppAdventureWorksLT.Commands;

namespace WpfAppAdventureWorksLT.ViewModels
{
    public class GenericViewModel<T>: BaseViewModel where T : class
    {

        private IUnitOfWork unitOfWork; 

        private IRepository<T>? repository;

        private CommandClass pageCommand;

        private int recordsPerPage = 10;

        private int recordCount = 0;

        public ICommand PageCommand { get { return pageCommand; } }

        private T? itemSelected;

        public T? ItemSelected
        {
            get { return itemSelected; }
            set
            {
                itemSelected = value;
                OnPropertyChanged(nameof(ItemSelected));
            }
        }


        public string TotalPages { get { return "Pages: " + maxPage(); } }


        public GenericViewModel()
        {
            unitOfWork = new UnitOfWork(new AdventureWorksLT2014Context());
            repository = unitOfWork.RepositoryFor<T>();
            selectedPage = 1;
            recordCount = repository.GetCount();
            pageCommand = new CommandClass(subNavigate, fnCanNavigate);
            ShowPageOfGrid(selectedPage);
            OnPropertyChanged("");
        }

        private ObservableCollection<T>? itemCollection;
        public ObservableCollection<T>? ItemCollection
        {
            get { return itemCollection; }
            set { 
                itemCollection = value; 
                OnPropertyChanged("ItemCollection"); 
            }
        }

        private int selectedPage;
        public int SelectedPage
        {
            get { return selectedPage; }
            set
            {
                selectedPage = value;

                OnPropertyChanged("SelectedPage");
                ShowPageOfGrid(selectedPage);
            }
        }



        private void ShowPageOfGrid(int nr = 1)
        {
            if (nr < 1) nr = 1;
            IEnumerable<T> prods = repository.GetPage(nr, recordsPerPage);
            ItemCollection = new ObservableCollection<T>(prods);
        }


        private int maxPage()
        {
            int page = 1;
            if (recordsPerPage > 0) page = (int)Math.Ceiling((float)recordCount / recordsPerPage);
            return page;
        }



        private void subNavigate(object? param)
        {
            if (param?.ToString() == "forward") SelectedPage++;
            if (param?.ToString() == "back") SelectedPage--;
            if (param?.ToString() == "first") SelectedPage = 1;
            if (param?.ToString() == "last") SelectedPage = maxPage();
            bntRefresh();
        }

        private bool fnCanNavigate(object? param)
        {
            if (param?.ToString() == "forward" && SelectedPage >= maxPage()) return false;
            if (param?.ToString() == "back" && SelectedPage <= 1) return false;
            if (param?.ToString() == "first" && SelectedPage <= 1) return false;
            if (param?.ToString() == "last" && SelectedPage >= maxPage()) return false;
            return true;
        }



        private void bntRefresh()
        {
            pageCommand.Refresh();
        }





    }
}
