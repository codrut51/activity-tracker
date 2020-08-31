using Activity.Models;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Activity.Repository
{
    public class ActivityRepository : IRepository<ActivityModel>
    {

        private readonly DbContextPg db;
        public ActivityRepository(DbContextPg db)
        {
            this.db = db;
        }

        public IQueryable<ActivityModel> getAll()
        {
            if (db.Activity.Count() != 0)
            {
                return db.Activity.AsQueryable();
            }
            return new List<ActivityModel>().AsQueryable();
        }

        public ActivityModel getOne(Guid id)
        {
            if(db.Activity.Count() != 0)
            {
                return db.Activity.FirstOrDefault(predicate => predicate.Id.Equals(id));
            }
            return null;
        }

        public bool addOne(ActivityModel item)
        {
            db.Activity.Add(item);
            int count = db.SaveChanges();
            return count > 0;
        }

        public bool updateOne(ActivityModel item)
        {
            db.Activity.Update(item);
            return true;
        }
    }
}