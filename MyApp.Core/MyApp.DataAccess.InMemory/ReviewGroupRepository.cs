using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccess.InMemory
{
    public class ReviewGroups
    {
        ObjectCache cache = MemoryCache.Default;
        List<ReviewGroups> reviewGroups;

        public ReviewGroups()
        {
            //checking the cache for reviews
            reviewGroups = cache["reviewGroups"] as List<ReviewGroups>;
            if (reviewGroups == null)
            {
                reviewGroups = new List<ReviewGroups>();
            }
        }

        //When people add reviews to the repository, wont save right away
        public void Commit()
        {
            cache["reviewGroups"] = reviewGroups;
        }

        //list functionality
        public void Insert(ReviewGroups rg)
        {
            reviewGroups.Add(rg);
        }
        public void Update(ReviewGroups reviewGroup)
        {
            //looking in database to find the product that is to be updated
            ReviewGroups reviewGroupToUpdate = reviewGroups.Find(rg => rg.Id == reviewGroup.Id);

            if (reviewGroupToUpdate != null)
            {
                reviewGroupToUpdate = reviewGroup;
            }
            else
            {
                throw new Exception("No reviews found");
            }
        }
        public ReviewGroups Find(string Id)
        {
            ReviewGroups reviewGroup = reviewGroups.Find(rg => rg.Id == Id);

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
        public IQueryable<ReviewGroups> Collection()
        {
            return reviewGroups.AsQueryable();
        }

        public void Delete(string Id)
        {
            ReviewGroups reviewGroupToDelete = reviewGroups.Find(r => r.Id == Id);

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
