using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Storage
    {
        [Key]
        public int StoragesID { get; set; }
        public string NameOfStorage { get; set; }
        public string InventoryNumber { get; set; }
        public string DesignatedEmployee { get; set; }
        public int SquareOfStorage { get; set; }
        public float Tonnage { get; set; }
        public float FillingPercentage { get; set; }
        public int TypeOfStoragesID { get; set; }

        public virtual ICollection<AcceptedRawMaterial> AcceptedRawMaterials { get; set; }

        public virtual TypeOfStorage TypeOfStorage { get; set; }

    }
}
