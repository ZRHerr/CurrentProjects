using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccess.InMemory
{
    public class ReviewGroupRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<ReviewGroup> reviewGroups;

        public ReviewGroupRepository()
        {
            //checking the cache for reviews
            reviewGroups = cache["reviewGroups"] as List<ReviewGroup>;
            if (reviewGroups == null)
            {
                reviewGroups = new List<ReviewGroup>();
            }
        }

        //When people add reviews to the repository, wont save right away
        public void Commit()
        {
            cache["reviewGroups"] = reviewGroups;
        }

        //list functionality
        public void Insert(ReviewGroup rg)
        {
            reviewGroups.Add(rg);
        }
        public void Update(ReviewGroup reviewGroup)
        {
            //looking in database to find the product that is to be updated
            ReviewGroup reviewGroupToUpdate = reviewGroups.Find(rg => rg.Id == reviewGroup.Id);

            if (reviewGroupToUpdate != null)
            {
                reviewGroupToUpdate = reviewGroup;
            }
            else
            {
                throw new Exception("No reviews found");
            }
        }
        public ReviewGroup Find(string Id)
        {
            ReviewGroup reviewGroup = reviewGroups.Find(rg => rg.Id == Id);

            if (reviewGroup != null)
            {
                return reviewGroup;
            }
            else
            {
                throw new Exception("No reviews found");
            }
        }

        //return a list of reviews that can be queried
        public IQueryable<ReviewGroup> Collection()
        {
            return reviewGroups.AsQueryable();
        }

        public void Delete(string Id)
        {
            ReviewGroup reviewGroupToDelete = reviewGroups.Find(r => r.Id == Id);

            if (reviewGroupToDelete != null)
            {
                reviewGroups.Remove(reviewGroupToDelete);
            }
            else
            {
                throw new Exception("No reviews found");
            }
        }

    }
}
