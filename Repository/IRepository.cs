using System.Linq;

namespace Activity.Repository 
{
    public interface IRepository<T> 
                     where T : new()
    {
        IQueryable<T> getAll();
        T getOne();
        bool addOne(T item);
        bool updateOne(T item);
    }
}