using System;
using Activity.Models;

namespace Activity.Repository {
    public class UserRepository : IRepository<UsersModel>
    {
        public bool addOne(UsersModel item)
        {
            return false;
        }

        public System.Linq.IQueryable<UsersModel> getAll()
        {
            return null;
        }

        public UsersModel getOne(Guid id)
        {
            return null;
        }

        public bool updateOne(UsersModel item)
        {
            return false;
        }
    }
}