using Activity.Models;
using System.Linq;
using System.Collections.Generic;

namespace Activity.Repository {
    public class ActivityRepository : IRepository<ActivityModel> {
        
        public IQueryable<ActivityModel> getAll() {
            List<ActivityModel> activities = new List<ActivityModel>();
            activities.Add(new ActivityModel() {
                Id = "1231231",
                Title = "My Title",
                Description = "My description"
            });
            return activities.AsQueryable();
        }

        public ActivityModel getOne() {
            return new ActivityModel() {
                Id = "1231231",
                Title = "My Title",
                Description = "My description"
            };
        }

        public bool addOne(ActivityModel item) {
            return true;
        } 

        public bool updateOne(ActivityModel item) {
            return true;
        } 
    }
}