using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class RawMaterial
    {
        [Key]
        public int RawMaterialsID { get; set; }
        public string RawMaterialsName { get; set; }
        public string DescriptionOfRawMaterials { get; set; }
        public string ReceptionConditions { get; set; }
        public string StorageConditions { get; set; }
        public decimal CostKG { get; set; }

        public virtual ICollection<AcceptedRawMaterial> AcceptedRawMaterials { get; set; }
        public RawMaterial()
        {
            AcceptedRawMaterials = new List<AcceptedRawMaterial>();

        }

    }
}
