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
            if (db.Activity.Count() != 0)
            {
                return db.Activity.FirstOrDefault(predicate => predicate.Id.Equals(id));
            }
            return null;
        }

        public void addOne(ActivityModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            db.Activity.Add(item);
        }

        public void updateOne(ActivityModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            db.Activity.Update(item);
        }

        public bool saveChanges()
        {
            return (db.SaveChanges() >= 0);
        }
    }
}