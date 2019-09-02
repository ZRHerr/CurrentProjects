using MyApp.Core.Contracts;
using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataAccess.SQL
{
    public class SQLRepository<Repo> : IRepository<Repo> where Repo : BaseEntity
    {
        internal DataContext context;
        internal DbSet<Repo> dbSet;

        public SQLRepository(DataContext context)
        {
            this.context = context;
            this.dbSet = context.Set<Repo>();
        }
        public IQueryable<Repo> Collection()
        {
            return dbSet;
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Delete(string Id)
        {
            var repo = Find(Id);
            if (context.Entry(repo).State == EntityState.Detached)
                dbSet.Attach(repo);

            dbSet.Remove(repo);
        }

        public Repo Find(string Id)
        {
            return dbSet.Find(Id);
        }

        public void Insert(Repo repo)
        {
            dbSet.Add(repo);
        }

        
        public void Update(Repo repo)
        {
            dbSet.Attach(repo);
            context.Entry(repo).State = EntityState.Modified;
        }
    }
}
