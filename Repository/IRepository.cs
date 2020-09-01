using System;
using System.Linq;

namespace Activity.Repository 
{
    public interface IRepository<T> 
                     where T : new()
    {
        IQueryable<T> getAll();
        T getOne(Guid id);
        void addOne(T item);
        void updateOne(T item);
        bool saveChanges();
    }

}