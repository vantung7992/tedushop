﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(Order = 1)]
        public int PostID { get; set; }

        [Key]
        [Column(TypeName = "varchar",Order =2)]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Posts { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { get; set; }
    }
}
