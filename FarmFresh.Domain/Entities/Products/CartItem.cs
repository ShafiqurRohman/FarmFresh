﻿using FarmFresh.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmFresh.Domain.Entities.Products
{
    [Table("CartItem", Schema = "dbo")]
    public class CartItem: BaseEntity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("UserId")]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Column("ProductId")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Column("Quantity")]
        [Required]
        public int Quantity { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
