using RPMS.Application.Persistence.Contracts;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Infrastructure.Repositories
{
    public class PositionRepository:GenericRepository<Position>,IPositionRepository
    {
       public readonly RpmsDbContext _dbContext;
        public PositionRepository(RpmsDbContext DbContext) : base(DbContext)
        {
            _dbContext = DbContext;
        }
    }
}
