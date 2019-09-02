using MyApp.Core.Contracts;
using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccess.InMemory
{
    public class InMemoryRepository<Repo> : IRepository<Repo> where Repo : BaseEntity
    {

        //memory cache
        ObjectCache cache = MemoryCache.Default;
        List<Repo> items;
        string className;

        //constructor
        public InMemoryRepository()
        {
            className = typeof(Repo).Name;
            items = cache[className] as List<Repo>;
            if (items == null)
            {
                items = new List<Repo>();
            }
        }

        //commit function for storing item in memory
        public void Commit()
        {
            cache[className] = items;
        }

        public void Insert(Repo repo)
        {
            items.Add(repo);
        }
        public void Update(Repo repo)
        {
            Repo repoToUpdate = items.Find(i => i.Id == repo.Id);
            if (repoToUpdate != null)
            {
                repoToUpdate = repo;
            }
            else
            {
                throw new Exception(className + "Not Found");
            }
        }
        public Repo Find(string Id)
        {
            Repo repo = items.Find(i => i.Id == Id);
            if (repo != null)
            {
                return repo;
            }
            else
            {
                throw new Exception(className + "Not Found");
            }
        }
        public IQueryable<Repo> Collection()
        {
            return items.AsQueryable();
        }
        public void Delete(string Id)
        {
            Repo repoToDelete = items.Find(i => i.Id == Id);
            if (repoToDelete != null)
            {
                items.Remove(repoToDelete);
            }
            else
            {
                throw new Exception(className + "Not Found");
            }

        }

    }
}
