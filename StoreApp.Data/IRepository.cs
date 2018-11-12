using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data
{
    public interface IRepository
    {
        void Create<T>(T item);

        List<T> Read<T>();
        T Read<T>(int itemId);

        void Update<T>(List<T> modelItemsList);

        void Delete<T>(List<T> modelItemsList);
    }
}
