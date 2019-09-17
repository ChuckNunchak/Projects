using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AcceptedRawMaterial
    {
        [Key]
        public int AcceptedRawMaterialsID { get; set; }
        public string TypeOfRawMaterials { get; set; }
        public int NumberKG { get; set; }
        public string Employee { get; set; }
        public string RoomOfStorage { get; set; }
        public DateTime DateAndTime { get; set; }
        public decimal Cost { get; set; }
        public int RawMaterialsID { get; set; }
        public int HumanResourcesDepartmentID { get; set; }
        public int StoragesID { get; set; }

        public virtual RawMaterial RawMaterial { get; set; }
        public virtual HumanResourceDepartment HumanResourceDepartment { get; set; }
        public virtual Storage Storage { get; set; }
    }
}
