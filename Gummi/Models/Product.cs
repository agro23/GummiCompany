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

        public Product() => this.Reviews = new HashSet<Review>();

        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public override bool Equals(System.Object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }
            else
            {
                Product newProduct = (Product)obj;
                return this.ProductId.Equals(newProduct.ProductId);
            }
        }

        public override int GetHashCode()
        {
            return this.ProductId.GetHashCode();
        }

        public double getAveragRating()
        {
            List<int> average = new List<int>();
            foreach (var review in Reviews)
            {
                average.Add(review.Rating);
            }
            return average.Average();
        }

    }
}
/*


List<Product> products = db.Products.Include(p => p.Reviews).ToList();
List<Product> sortedProducts = products.OrderByDescending(p => p.AverageRating()).ToList();
if (sortedProducts.Count >= 3)
{
   List<Product> topThree = new List<Product> { sortedProducts[0], sortedProducts[1], sortedProducts[2] };
   return View(topThree);
}
else
{
   return View(sortedProducts);
}



*/