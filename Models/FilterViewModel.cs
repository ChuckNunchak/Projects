using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Models
{
    public enum SortState
    {
        NameAsc,    // по имени по возрастанию
        NameDesc,   // по имени по убыванию
        CostAsc, // по цене по возрастанию
        CostDesc,    // по цене по убыванию
        StorageAsc, // по помещению по возрастанию
        StorageDesc // по помещению по убыванию
    }
    public class FilterViewModel
    {
        public FilterViewModel(List<Storage> storages, int? storage, string TypeOfRawMaterials)
        {
            storages.Insert(0, new Storage { NameOfStorage = "Все", StoragesID = 0 });
            Storages = new SelectList(storages, "Id", "Name", storage);
            SelectedStorage = storage;
            SelectedName = TypeOfRawMaterials;
        }
        public SelectList Storages { get; private set; } // список помещений
        public int? SelectedStorage { get; private set; }   // выбранное помещение
        public string SelectedName { get; private set; }    // введенное имя
    }
}
