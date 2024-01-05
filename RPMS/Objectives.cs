using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Domain
{
    public class Objectives
    {
        public int Id { get; set; }
        public int Kra { get; set; }
        public string? Objectivename  { get; set; }
        public Akras Akras { get; set; } = null!;
        public ICollection<Performance> Performance { get; set; }= new List<Performance>();

    }
}
