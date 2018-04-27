using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gummi.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        //public int ReviewId { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        //public ICollection<Location> Locations { get; set; }
    }
}
