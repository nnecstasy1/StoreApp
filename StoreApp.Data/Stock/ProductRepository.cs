﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Stock
{
    public class ProductRepository : IRepository
    {
        public void Create<T>(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(List<T> modelItemsList)
        {
            throw new NotImplementedException();
        }

        public List<T> Read<T>()
        {
            throw new NotImplementedException();
        }

        public T Read<T>(int itemId)
        {
            throw new NotImplementedException();
        }

        public void Update<T>(List<T> modelItemsList)
        {
            throw new NotImplementedException();
        }
    }
}
