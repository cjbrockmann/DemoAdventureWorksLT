using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using WpfAppAdventureWorksLT.Commands;

namespace WpfAppAdventureWorksLT.ViewModels
{
    public class MainVM : INotifyPropertyChanged 
    {
        private BaseViewModel? _selectedViewModel;

        public BaseViewModel? SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { 
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }


        private ObservableCollection<string> myViewList = new ObservableCollection<string>();


        public ObservableCollection<string> MyViewList
        {
            get { return myViewList; }
            set { 
                myViewList = value;
                OnPropertyChanged(nameof(MyViewList));
            }
        }


        public ICommand UpdateViewCommand { get; set; }

        public MainVM()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
            MyViewList = new ObservableCollection<string>(GLOBALS.ListOfViews); 
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
