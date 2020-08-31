using System;
using System.Collections.Generic;

namespace Activity.Data {
    public class UserDto {
        public Guid id;
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string password { private get; set; }
        public DateTime createdOn { get; set; } 
        public DateTime lastLogin { get; set; }
        public ICollection<ActivityDto> Activities {get; set;}
    }
}