using System.Linq;
using MyApp.Core.Models;

namespace MyApp.Core.Contracts
{
    public interface IRepository<Repo> where Repo : BaseEntity
    {
        IQueryable<Repo> Collection();
        void Commit();
        void Delete(string Id);
        Repo Find(string Id);
        void Insert(Repo repo);
        void Update(Repo repo);
    }
}