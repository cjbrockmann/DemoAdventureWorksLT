using DemoAdventureWorks.DAL.Core;
using DemoAdventureWorks.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppAdventureWorksLT.Models;
using WpfAppAdventureWorksLT.ViewModels;

namespace WpfAppAdventureWorksLT
{



    public static class GLOBALS
    {

        static IUnitOfWork unitOfWork; 

        static GLOBALS()
        {
            ViewList = new List<string> {
                   "Addresses"
                 , "Customers"
                 , "Products"
                };  

        }
        
        public static List<string> ViewList { get; set; }


        public static List<string> ListOfViews { get {
                return ViewList; 
            } 
        }


        public static BaseViewModel? ViewModelFactory(string param)
        {
            if (param == "Adresses") return new AddressCollectionVM();
            if (param == "Customers") return new GenericViewModel<Customer>();
            if (param == "Products") return new ProductCollectionVM();
            return null; 
        }


    }
}




/*
    return new List<string> { 
    "Address"
    , "Customer"
    , "CustomerAddress"
    , "Product"
    , "ProductCategory"
    , "ProductDescription"
    , "ProductModel"
    , "ProductModelProductDescription"
    , "SalesOrderDetail"
    , "SalesOrderHeader" 
    }; 
 
 */

