using System;
using System.Collections.Generic;
using StoreApp.Data;
using StoreApp.Model.Stock;
using StoreApp.Data.Stock;

namespace StoreApp.Logic
{
    public class CategoryBL
    {
        private CategoryRepository _categoryRepository;

        public CategoryBL(AppEntities appEntities)
        {
            _categoryRepository = new CategoryRepository(appEntities);
        }

        public List<Category> GetCategories()
        {
            var categories = _categoryRepository.Read<Category>();
            return categories;
        }

        public void AddCategory(CategoryViewModel category)
        {
            try
            {
                if (ValidateModel(category))
                {
                    _categoryRepository.Create(
                        new Category()
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

        public void UpdateCategory()
        {
            //TO DO:
            _categoryRepository.Update(null as List<Category>);
        }

        private bool ValidateModel(CategoryViewModel categoryViewModel)
        {
            return true;
        }
    }
}
