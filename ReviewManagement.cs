using System;
using System.Collections.Generic;
using System.Data;
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
                Console.WriteLine(list.ProductId + " \t\t " + list.UserId + " \t\t " + list.Rating + "  \t\t " + list.Review + " \t\t " + list.isLike);
            }
        }

        public void GreaterThanThreeRatingRecords(List<ProductReview> reviewList)
        {
            var records = (from products in reviewList
                           where (products.ProductId == 1 ||
                           products.ProductId == 4 ||
                           products.ProductId == 9)
                           && products.Rating > 3
                           select products);
            Console.WriteLine("Product Id \t User Id \t Rating \t Review \t Is Like");
            foreach (var list in records)
            {
                Console.WriteLine(list.ProductId + " \t\t " + list.UserId + " \t\t " + list.Rating + "  \t\t " + list.Review + " \t\t " + list.isLike);
            }
        }

        public void ProductIdCount(List<ProductReview> reviewList)
        {
            var records = reviewList.GroupBy(p => p.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            Console.WriteLine("Product Id \t Count");
            foreach (var list in records)
            {
                Console.WriteLine(list.ProductId + " \t\t " + list.Count);
            }
        }
        //UC5   UC7
        public void ProductReview(List<ProductReview> reviewList)
        {
            var records = from products in reviewList select new { ProductId = products.ProductId, Review = products.Review };
            Console.WriteLine("Product Id \t Review");
            foreach (var list in records)
            {
                Console.WriteLine(list.ProductId + " \t\t " + list.Review);
            }
        }

        public void SkipTopFiveRecord(List<ProductReview> reviewList)
        {
            var records = (from product in reviewList orderby product.Rating descending select product).Skip(5).ToList();
            Console.WriteLine("Product Id \t User Id \t Rating \t Review \t Is Like");
            foreach (var list in records)
            {
                Console.WriteLine(list.ProductId + " \t\t " + list.UserId + " \t\t " + list.Rating + "  \t\t " + list.Review + " \t\t " + list.isLike);
            }
        }

        public void DataTable(List<ProductReview> reviewList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId");
            dt.Columns.Add("UserId");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Review");
            dt.Columns.Add("IsLike");

            foreach (var list in reviewList)
            {
                dt.Rows.Add(list.ProductId,list.UserId,list.Rating,list.Review,list.isLike);
            }
        }
    }
}
