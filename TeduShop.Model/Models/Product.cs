﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        public int CategoryID { get; set; }
        public string Image { get; set; }
        public XElement MoreImage { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }
    }
}