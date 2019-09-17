using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SortViewModel
    {
        public SortState NameSort { get; private set; } // значение для сортировки по имени
        public SortState CostSort { get; private set; }    // значение для сортировки по цене
        public SortState StorageSort { get; private set; }   // значение для сортировки по помещению
        public SortState Current { get; private set; }     // текущее значение сортировки

        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            CostSort = sortOrder == SortState.CostAsc ? SortState.CostDesc : SortState.CostAsc;
            StorageSort = sortOrder == SortState.StorageAsc ? SortState.StorageDesc : SortState.StorageAsc;
            Current = sortOrder;
        }
    }
}
