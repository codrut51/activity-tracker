using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Activity.Models
{
    [Table("users")]
    public class UsersModel
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        
        [Column("firstname")]
        public string FirstName { get; set; }
        
        [Column("lastname")]
        public string LastdName { get; set; }
        
        [Column("password")]
        public string Password { get; set; }
        
        [Column("email")]
        public string Email { get; set; }
        
        [Column("created_on")]
        public DateTime CreatedOn { get; set; }
        
        [Column("last_login")]
        public DateTime LastLogin { get; set; }
        public ICollection<ActivityModel> Activities { get; set; }
    }
}