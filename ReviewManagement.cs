using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class ReviewManagement
    {
        public void TopThreeRecords(List<ProductReview> reviewList)
        {
            var records = (from products in reviewList
                              orderby products.Rating descending
                              select products).Take(3);

            Console.WriteLine("Product Id \t User Id \t Rating \t Review \t Is Like");
            foreach (var list in records)
            {
                Console.WriteLine( list.ProductId + " \t\t " + list.UserId + " \t\t " + list.Rating + "  \t\t " + list.Review + " \t\t " + list.isLike);
            }
        }

    }
}
