using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDelegate.Repository.IRepository
{
    public interface IService<T>
    {
        T Create(T model);
        T Update(int id, T model);
        bool Delete(int id);
        T[] Read();
        T Find(int id);
    }
}
