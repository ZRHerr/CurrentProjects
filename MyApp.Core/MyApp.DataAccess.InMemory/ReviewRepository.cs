using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using MyApp.Core.Models;

namespace MyApp.DataAccess.InMemory
{
    public class ReviewRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<Review> reviews;

        public ReviewRepository()
        {
            //checking the cache for reviews
            reviews = cache["reviews"] as List<Review>;
            if(reviews == null)
            {
                reviews = new List<Review>();
            }
        }

        //When people add reviews to the repository, wont save right away
        public void Commit()
        {
            cache["reviews"] = reviews;
        }

        //list functionality
        public void Insert(Review r)
        {
            reviews.Add(r);
        }
        public void Update(Review review)
        {
            //looking in database to find the product that is to be updated
            Review reviewToUpdate = reviews.Find(r => r.Id == review.Id);

            if(reviewToUpdate != null)
            {
                reviewToUpdate = review;
            }
            else
            {
                throw new Exception("No reviews found");
            }
        }
        public Review Find(string Id)
        {
            Review review = reviews.Find(r => r.Id == Id);

            if (review != null)
            {
                return review;
            }
            else
            {
                throw new Exception("No reviews found");
            }
        }

        //return a list of reviews that can be queried
        public IQueryable<Review> Collection()
        {
            return reviews.AsQueryable();
        }

        public void Delete (string Id)
        {
            Review reviewToDelete = reviews.Find(r => r.Id == Id);

            if (reviewToDelete != null)
            {
                reviews.Remove(reviewToDelete);
            }
            else
            {
                throw new Exception("No reviews found");
            }
        }

    }
}
