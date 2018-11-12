using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using StoreApp.Data;
using StoreApp.Logic;
using StoreApp.Model.Stock;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var _appEntities = new AppEntities();

            CategoryBL _categoryBl = new CategoryBL(_appEntities);
            _categoryBl.UpdateCategory();
            var x  = _categoryBl.GetCategories();

            ////test add
            //CategoryViewModel categoryViewModel = new CategoryViewModel
            //{
            //    categoryName = "Category A",
            //    description = "category A description"
            //};

            //_categoryBl.AddCategory(categoryViewModel);
        }
    }
}
