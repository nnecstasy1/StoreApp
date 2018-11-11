using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Stock
{
    public interface IStockCRUD
    {
        void Create<T>(T item);

        List<T> Read<T>();
        T Read<T>(int itemId);

        void Update<T>(List<T> itemsList);

        void Delete<T>(List<T> itemsList);
    }
}
