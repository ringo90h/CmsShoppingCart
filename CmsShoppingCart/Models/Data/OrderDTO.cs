﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CmsShoppingCart.Models.Data
{
    [Table("tblOrder")]
    public class OrderDTO
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("UserId")]
        public virtual UserDTO users { get; set; }

    }
}