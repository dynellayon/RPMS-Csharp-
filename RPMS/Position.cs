using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Domain
{
    public class Position
    {
        public int Id { get; set; }
        public string PositionName { get; set; } = string.Empty;
        public string PositionType { get; set; } = string.Empty;

    }
}
