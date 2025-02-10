using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EfCorePostgresDemo.Models
{
    public class CardItem
    {
        [Key]
        public int CardItemID { get; set; }
        [Required]
        [ForeignKey(nameof(Card))]
        public int CardID { get; set; }
        public Card? Cards { get; set; }
        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductID { get; set; }
        public Product? Products { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}