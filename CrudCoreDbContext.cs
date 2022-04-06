using System;
using SSTDataAccess;
using Microsoft.EntityFrameworkCore;

namespace SSTRepository
{
    public partial class CrudCoreDbContext : DbContext
    {
        public CrudCoreDbContext()
        {
        }

        public CrudCoreDbContext(DbContextOptions<CrudCoreDbContext> options)
            : base(options)
        {
        }
    }
}