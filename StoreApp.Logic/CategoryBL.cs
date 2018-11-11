using System;
using System.Collections.Generic;
using StoreApp.Model.Stock;
using StoreApp.Data.Stock;

namespace StoreApp.Logic
{
    public class CategoryBL
    {
        private Category _categoryDB;

        public CategoryBL(StoreApp.Data.AppEntities connection)
        {
            _categoryDB = new Category(connection);
        }

        public List<Data.Category> GetCategories()
        {
            var categories = _categoryDB.Read<Data.Category>();
            return categories;
        }

        public void AddCategory(CategoryViewModel category)
        {
            try
            {
                if (ValidateModel(category))
                {
                    _categoryDB.Create(
                        new Data.Category()
                        {
                            categoryName = category.categoryName,
                            description = category.description
                        });
                    return;
                }
                else
                {
                    //TO DO: send back error message if Model was not valid.
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private bool ValidateModel(CategoryViewModel categoryView)
        {
            return true;
        }
    }
}
