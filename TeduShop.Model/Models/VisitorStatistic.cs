﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("VisotorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public DateTime VisiteDate { get; set; }

        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}