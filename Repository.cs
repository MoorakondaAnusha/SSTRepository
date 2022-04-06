using SSTDataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SSTRepository
{
    public class Repository<T>:IRepository<T> where T : UserBase
    {
        private readonly CrudCoreDbContext context;
        private readonly DbSet<T> entities;
        public Repository(CrudCoreDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public T Get(int id)
        {
            return entities.SingleOrDefault(p => p.UserId == id);
        }
    }
}
