using System;

namespace Activity.Data.Read
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastLogin { get; set; }
    }
}