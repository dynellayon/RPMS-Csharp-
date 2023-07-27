using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Infrastructure
{
    public class RpmsDbContext:DbContext
    {
        public RpmsDbContext(DbContextOptions<RpmsDbContext> options) : base(options) { }
    }
}
