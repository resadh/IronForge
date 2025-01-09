using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        [Required]
        [StringLength(150)]
        public string InventoryName { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Kolicina mora biti nula ili veca od nule.")]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Cena mora biti nula ili veca od nule.")]
        public double Price { get; set; }

        public List<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();
    }
}
