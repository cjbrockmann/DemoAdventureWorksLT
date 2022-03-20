using DemoAdventureWorks.DAL.Context;
using DemoAdventureWorks.DAL.Core;
using DemoAdventureWorks.DAL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppAdventureWorksLT.Commands;

namespace WpfAppAdventureWorksLT.ViewModels
{
    public class ProductCollectionVM : GenericViewModel<Product>
    {
        public ProductCollectionVM() : base() { }
    }
}
