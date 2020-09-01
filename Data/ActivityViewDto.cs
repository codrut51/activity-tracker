using System;

namespace Activity.Data {
    public class ActivityViewDto {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
    }
}