using RPMS.Application.Persistence.Contracts;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Infrastructure.Repositories
{
    public class AkrasRepository : GenericRepository<Akras>,IKrasRepository
    {
        public readonly RpmsDbContext _dbContext;
        public AkrasRepository(RpmsDbContext DbContext) : base(DbContext)
        {
            _dbContext= DbContext;
        }
    }
}
