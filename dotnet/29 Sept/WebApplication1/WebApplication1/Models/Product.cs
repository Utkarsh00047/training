using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    [Table("Product")]
    public partial class Product
    {
        [Key]
        [Column("pro_id")]
        public int ProId { get; set; }
        [Column("pro_name")]
        [StringLength(25)]
        [Unicode(false)]
        public string? ProName { get; set; }
        [Column("pro_cost")]
        public int? ProCost { get; set; }
        [Column("cat_id")]
        public int? CatId { get; set; }

        [ForeignKey("CatId")]
        [InverseProperty("Products")]
        public virtual Category? Cat { get; set; }
    }
}
