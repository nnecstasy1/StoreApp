using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Data.Stock
{
    public class Category : IStockCRUD
    {
        AppEntities dbConnection;
        public Category(AppEntities connection)
        {
            dbConnection = connection;
        }

        public void Create<T>(T modelItem)
        {
            Data.Category category = modelItem as Data.Category;
            if (category != null)
            {
                dbConnection.Categories.Add(category);
                dbConnection.SaveChanges();
            }
        }

        public List<T> Read<T>()
        {
            List<Data.Category> categories = dbConnection.Categories.ToList();
            return categories;
        }

        public T Read<T>(int itemId)
        {
            Data.Category category = Read<Data.Category>().First(categoryItem => categoryItem.categoryId == itemId);
            return category;
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
                dbConnection.Categories.RemoveRange(modelItemsList as List<Data.Category>);
                dbConnection.SaveChanges();
            }
        }

        private void UpdateCategory(Data.Category categoryToUpdate)
        {
            Data.Category currentCategory = (from c in dbConnection.Categories
                where c.categoryId == categoryToUpdate.categoryId
                select c).First();

            //TO DO: assign new values to variables updated in the model
            dbConnection.SaveChanges();
        }
    }
}
