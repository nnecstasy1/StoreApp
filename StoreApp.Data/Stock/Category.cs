using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Data.Stock
{
    public class Category : ICrud
    {
        private AppEntities _dbConnection;
        public Category(AppEntities connection)
        {
            _dbConnection = connection;
        }

        public void Create<T>(T modelItem)
        {
            Data.Category category = modelItem as Data.Category;
            if (category != null)
            {
                _dbConnection.Categories.Add(category);
                _dbConnection.SaveChanges();
            }
        }

        public List<T> Read<T>()
        {
            List<Data.Category> categories = _dbConnection.Categories.ToList();
            return (List<T>)Convert.ChangeType(categories, typeof(List<T>));
        }

        public T Read<T>(int itemId)
        {
            Data.Category category = Read<Data.Category>().First(categoryItem => categoryItem.categoryId == itemId);
            return (T)Convert.ChangeType(category, typeof(T));
        }

        public void Update<T>(List<T> itemsList)
        {
            Parallel.ForEach(itemsList, categoryItem =>
            {
                UpdateCategory(categoryItem as Data.Category);
            });
        }

        public void Delete<T>(List<T> modelItemsList)
        {
            if (modelItemsList != null)
            {
                _dbConnection.Categories.RemoveRange(modelItemsList as List<Data.Category>);
                _dbConnection.SaveChanges();
            }
        }

        private void UpdateCategory(Data.Category categoryToUpdate)
        {
            Data.Category currentCategory = (from c in _dbConnection.Categories
                where c.categoryId == categoryToUpdate.categoryId
                select c).First();
            
            //TO DO: assign new values to variables updated in the model, above variable is unused
            _dbConnection.SaveChanges();
            _dbConnection.SaveChanges();
        }
    }
}
