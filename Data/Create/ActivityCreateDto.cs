using System;

namespace Activity.Data.Create
{
    public class ActivityCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
    }
}