using System;

namespace Activity.Data.Read
{
    public class ActivityDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModified { get; set; }
    }
}