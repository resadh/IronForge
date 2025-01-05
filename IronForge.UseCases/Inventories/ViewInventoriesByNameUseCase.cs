using IronForge.CoreBusiness;
using IronForge.UseCases.Inventories.Interfaces;
using IronForge.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronForge.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = " ")
        {
            return await inventoryRepository.GetInventoriesByNameAsync(name);

        }
    }
}
