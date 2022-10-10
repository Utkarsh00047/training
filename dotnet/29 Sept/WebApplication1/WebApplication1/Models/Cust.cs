using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    [Table("Cust")]
    public partial class Cust
    {
        [Key]
        [Column("cust_id")]
        public int CustId { get; set; }
        [Column("cust_name")]
        [StringLength(25)]
        [Unicode(false)]
        public string? CustName { get; set; }
        [Column("pic_url")]
        [StringLength(25)]
        [Unicode(false)]
        public string? PicUrl { get; set; }
    }
}
