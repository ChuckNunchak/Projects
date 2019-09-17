using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TypeOfStorage
    {
        [Key]
        public int TypeOfStoragesID { get; set; }
        public string NameOfTypeOfStorages { get; set; }
        public string TypesOfRawMaterialsInStorage { get; set; }
        public bool FireProtection { get; set; }
        public bool SpecialEquipment { get; set; }
        public float Humidity { get; set; }

        public virtual ICollection<Storage> Storages { get; set; }
    }
}
