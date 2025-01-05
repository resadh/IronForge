using IronForge.CoreBusiness;

namespace IronForge.UseCases.Inventories.Interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = " ");
    }
}