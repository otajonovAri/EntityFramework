using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EfCorePostgresDemo.Models
{
    public class Card
    {
        [Key]
        public int CardID { get; set; }
        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerID { get; set; }
        public Customer? Customers { get; set; }
        public ICollection<CardItem>? CardItems { get; set; }
    }
}