using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Activity.Models
{
    [Table("activity")]
    public class ActivityModel
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("userid")]
        public UsersModel User { get; set; }
        
        [Required]
        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Required]
        [Column("created_on")]
        public DateTime CreatedOn { get; set; }
        
        [Column("last_modified")]
        public DateTime LastModified { get; set; }
    }
}