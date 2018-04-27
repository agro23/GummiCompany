using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gummi.Models
{
    [Table("Products")]
    public class Product
    {

        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        //override Equals here. Should just get into that habit.

        public int getAverageRating (){
            Console.WriteLine("This will average all of the ratings from all of the reviews, right?");
            var average = 3; // just the test rating for now
            return average;
        }

    }
}
