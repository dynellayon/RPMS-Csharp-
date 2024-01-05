using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Domain
{
   public class Performance
    {
        public int Id { get; set; }
        public string? QET { get; set; }
        public string? Outstanding { get; set;}
        public string? VerySatisfactory { get; set; }
        public string? Satisfactory { get; set; }
        public string? Unsatisfactory { get; set; }
        public string? Poor { get; set; }
        public int ObjectiveID { get; set; }
        public Objectives Objectives { get; set; } = null!;
    }
}
