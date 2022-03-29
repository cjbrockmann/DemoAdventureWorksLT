using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppAdventureWorksLT.ViewModels;

namespace WpfAppAdventureWorksLT.Models
{

    public class ViewProperties
    {

        public ViewProperties()
        {
            Id = String.Empty;
            Name = string.Empty; 
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public BaseViewModel? viewModel { get; set; }

    }
}
