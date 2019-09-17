using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class IndexViewModel
    {
        public IEnumerable<RawMaterial> RawMaterials { get; set; }
        public IEnumerable<AcceptedRawMaterial> AcceptedRawMaterials { get; set; }
        public IEnumerable<HumanResourceDepartment> HumanResourcesDepartment { get; set; }
        public IEnumerable<Storage> Storages { get; set; }
        public IEnumerable<TypeOfStorage> TypeOfStorages { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public SortViewModel SortViewModel { get; set; }
    }
}
