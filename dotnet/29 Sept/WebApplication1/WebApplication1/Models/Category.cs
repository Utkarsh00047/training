using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [Column("cat_id")]
        public int CatId { get; set; }
        [Column("cat_name")]
        [StringLength(25)]
        [Unicode(false)]
        public string? CatName { get; set; }

        [InverseProperty("Cat")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
