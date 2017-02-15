﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public string UpdateBy { set; get; }

        public bool Status { set; get; }

        [MaxLength(256)]
        public string MetaKeywork { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }
    }
}