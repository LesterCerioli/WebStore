using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Infrastructure.Data;
using WebStore.Infrastructure.Models;

namespace WebStore.Modules.Core.Data
{
    public class Repository<T> : RepositoryWithTypedId<T, long>, IRepository<T>
        where T : class, IEntityWithTypedId<long>
    {
        public Repository(WebStoreDbContext context) : base(context)
        {
        }
    }
}
