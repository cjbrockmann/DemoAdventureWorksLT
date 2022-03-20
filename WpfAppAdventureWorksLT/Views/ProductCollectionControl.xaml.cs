using DemoAdventureWorks.DAL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppAdventureWorksLT.Views
{
    /// <summary>
    /// Interaktionslogik für ProductsDatagridControl.xaml
    /// </summary>
    public partial class ProductCollectionControl : UserControl 
    {
        public ProductCollectionControl()
        {
            InitializeComponent();
        }


        //public static readonly DependencyProperty ProductCollectionProperty 
        //    = DependencyProperty.Register("ProductCollection",typeof(ObservableCollection<Product>)
        //        , typeof(ProductsDatagridControl)
        //        , new UIPropertyMetadata(null,subProductCollectionChangedCallback)) ;

        //private static void subProductCollectionChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    ProductsDatagridControl productsDatagridControl = (ProductsDatagridControl) d;
        //    productsDatagridControl.grdProducts.ItemsSource = (ObservableCollection<Product>) e.NewValue;
        //}

        //public ObservableCollection<Product>? ProductCollection
        //{
        //    get { return (ObservableCollection<Product>) GetValue(ProductCollectionProperty); }
        //    set { SetValue(ProductCollectionProperty,value) ;}
        //}



    }
}
