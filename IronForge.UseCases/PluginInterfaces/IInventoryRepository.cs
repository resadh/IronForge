using IronForge.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronForge.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
    }
}
