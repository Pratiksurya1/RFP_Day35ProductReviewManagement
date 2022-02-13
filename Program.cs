using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            List<ProductReview> productlist = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 4, UserId = 1, Rating = 2.1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 6, UserId = 2, Rating = 1.5, Review = "Very Bad", isLike = false },
                new ProductReview() { ProductId = 1, UserId = 3, Rating = 4.5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 5, Rating = 4.1, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 6, Rating = 4.9, Review = "Very Good ", isLike = false },
                new ProductReview() { ProductId = 6, UserId = 9, Rating = 3.5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 8, UserId = 1, Rating = 1.7, Review = "Very Bad ", isLike = true },
                new ProductReview() { ProductId = 5, UserId = 6, Rating = 2.2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 2, UserId = 4, Rating = 1.7, Review = "Bad", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 8, Rating = 1.7, Review = "Very Bad", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 7, Rating = 3.1, Review = "Very Good", isLike = true },
                new ProductReview() { ProductId = 8, UserId = 2, Rating = 1.7, Review = "Good", isLike = false },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 4.9, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 8, UserId = 5, Rating = 3.8, Review = "Very Good", isLike = true },
                new ProductReview() { ProductId = 6, UserId = 4, Rating = 3.1, Review = "Good", isLike = false },
                new ProductReview() { ProductId = 8, UserId = 3, Rating = 4.5, Review = "Good", isLike = false },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 1.7, Review = "Very Good", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 3, Rating = 2.7, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 1, Rating = 4.5, Review = "Very Good", isLike = false },
                new ProductReview() { ProductId = 6, UserId = 3, Rating = 3.1, Review = "Bad", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 2, Rating = 1.7, Review = "Very Bad", isLike = false },
                new ProductReview() { ProductId = 1, UserId = 5, Rating = 3.1, Review = "Very Good ", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 1, Rating = 4.5, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 3, UserId = 7, Rating = 4.5, Review = "VeryGood", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 5, Rating = 1.7, Review = "Very Bad", isLike = false }
            };

            ReviewManagement review= new ReviewManagement();
            review.TopThreeRecords(productlist);
            
            Console.WriteLine("\n\n");
            review.GreaterThanThreeRatingRecords(productlist);

            Console.WriteLine("\n\n");
            review.ProductIdCount(productlist);

            Console.WriteLine("\n\n");
            review.ProductReview(productlist);

            Console.WriteLine("\n\n");
            review.SkipTopFiveRecord(productlist);

            DataTable dt =review.DataTableLinQ(productlist);

            Console.WriteLine("\n\n");
            review.isLikeTrueRecord(dt);
        }
    }
}