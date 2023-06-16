using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ForeignKeyImplementation.Models
{
    
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string? Name { get; set; }

        [JsonIgnore]
        public ICollection<Order>? Orders { get; set; }
    }
}
