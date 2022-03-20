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
        public string Id { get; set; }
        public string Name { get; set; }

        public BaseViewModel? viewModel { get; set; }

    }
}
