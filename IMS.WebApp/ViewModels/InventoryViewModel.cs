using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
    public class InventoryViewModel
    {
        public int InventoryId { get; set; }

        [Required]
        [StringLength(150)]
        public string InventoryName { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Kolicina mora biti jednaka ili veca od 0.")]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Cena mora biti jednaka ili veca od 0.")]
        public double Price { get; set; }
        
    }
}
