using System;

namespace Activity.Data {
    public class ActivityDto {
        public Guid id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModified { get; set; }
    }
}