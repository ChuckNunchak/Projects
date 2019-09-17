using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class RawMaterialsContext:DbContext
    {
        public RawMaterialsContext(DbContextOptions<RawMaterialsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<AcceptedRawMaterial> AcceptedRawMaterials { get; set; }
        public DbSet<HumanResourceDepartment> HumanResourcesDepartment { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<TypeOfStorage> TypeOfStorages { get; set; }
    }
}
