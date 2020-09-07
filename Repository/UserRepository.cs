using System;
using System.Collections.Generic;
using System.Linq;
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
            if(db.Users.Count() != 0)
            {
                return db.Users.AsQueryable();
            }
            return new List<UsersModel>().AsQueryable();
        }

        public UsersModel getOne(Guid id)
        {
            if (db.Users.Count() != 0)
            {
                return db.Users.FirstOrDefault(p => p.Id.Equals(id));
            }
            return null;
        }

        public bool saveChanges()
        {
            return db.SaveChanges() > 0;
        }

        public void updateOne(UsersModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            db.Users.Update(item);
        }
    }
}