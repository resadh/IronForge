using System.ComponentModel.DataAnnotations;

namespace IMS.WebApp.ViewModels
{
    public class PurchaseViewModel
    {
        [Required]
        public string PONumber { get; set; } = string.Empty;

        [Range(minimum: 1, maximum:int.MaxValue, ErrorMessage = "Morate da izabete inventar")]
        public int InventoryId { get; set; }

        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Kolicina mora biti jednaka ili veca od 1.")]
        public int QuantityToPurchase { get; set; }

        public double InventoryPrice { get; set; }
    }
}
