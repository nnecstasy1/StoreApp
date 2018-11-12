using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Data.Stock
{
    public class CategoryRepository : IRepository
    {
        private AppEntities _appEntities;

        public CategoryRepository(AppEntities appEntities)
        {
            _appEntities = appEntities;
        }

        public void Create<T>(T modelItem)
        {
            Category category = modelItem as Category;
            if (category != null)
            {
                _appEntities.Categories.Add(category);
                _appEntities.SaveChanges();
            }
        }

        public List<T> Read<T>()
        {
            List<Category> categories = _appEntities.Categories.ToList();
            return (List<T>)Convert.ChangeType(categories, typeof(List<T>));
        }

        public T Read<T>(int itemId)
        {
            Category category = Read<Category>().First(categoryItem => categoryItem.categoryId == itemId);
            return (T)Convert.ChangeType(category, typeof(T));
        }

        public void Update<T>(List<T> itemsList)
        {
            var categoriesToUpdate = itemsList as List<Category>;

            if (categoriesToUpdate != null)
            {
                _appEntities.Categories.AddOrUpdate(categoriesToUpdate.ToArray());
                _appEntities.SaveChanges();
            }
        }

        public void Delete<T>(List<T> modelItemsList)
        {
            if (modelItemsList != null)
            {
                _appEntities.Categories.RemoveRange(modelItemsList as List<Category>);
                _appEntities.SaveChanges();
            }
        }
    }
}
