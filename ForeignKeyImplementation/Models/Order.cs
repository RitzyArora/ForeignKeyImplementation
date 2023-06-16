using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ForeignKeyImplementation.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public string? OrderNumber { get; set; }
        [Required]
        
        public int CustomerId { get; set; }
        [JsonIgnore]
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
    }
}
