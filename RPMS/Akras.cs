using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Domain
{
    public class Akras
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Objectives> Objectives { get; set; }=new List<Objectives>();
    }
}
