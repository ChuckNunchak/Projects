using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class HumanResourceDepartment
    {
        [Key]
        public int HumanResourcesDepartmentID { get; set; }
        public string Initial { get; set; }
        public int LengthOfService { get; set; }
        public string AcceptRawMaterials { get; set; }

        public virtual ICollection<AcceptedRawMaterial> AcceptedRawMaterials { get; set; }
    }
}
