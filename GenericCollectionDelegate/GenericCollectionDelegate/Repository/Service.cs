using GenericCollectionDelegate.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDelegate.Repository
{
    public class Service<T> : IService<T>
    {
        public T Create(T model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Find(int id)
        {
            throw new NotImplementedException();
        }

        public T[] Read()
        {
            throw new NotImplementedException();
        }

        public T Update(int id, T model)
        {
            throw new NotImplementedException();
        }
    }
}
