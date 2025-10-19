using System.ComponentModel.DataAnnotations;

namespace InventryManageMent.Models;

    public class InventoryItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
    }

