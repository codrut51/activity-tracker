using System;
using Activity.Models;

namespace Activity.Repository
{
    public class UserRepository : IRepository<UsersModel>
    {
        private readonly DbContextPg db;
        public UserRepository(DbContextPg db)
        {
            this.db = db;
        }

        public void addOne(UsersModel item)
        {
        }

        public System.Linq.IQueryable<UsersModel> getAll()
        {
            return null;
        }

        public UsersModel getOne(Guid id)
        {
            return null;
        }

        public bool saveChanges()
        {
            throw new NotImplementedException();
        }

        public void updateOne(UsersModel item)
        {
        }
    }
}