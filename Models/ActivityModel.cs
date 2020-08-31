using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Activity.Models
{
    [Table("activity")]
    public class ActivityModel
    {
        [Column("id")]
        public Guid Id { get; set; }

        [ForeignKey("userid")]
        public UsersModel User { get; set; }
        
        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }
        
        [Column("created_on")]
        public DateTime CreatedOn { get; set; }
        
        [Column("created_on")]
        public DateTime LastModified { get; set; }
    }
}