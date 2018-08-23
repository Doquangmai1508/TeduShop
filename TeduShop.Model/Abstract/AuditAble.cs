﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TeduShop.Model.Abstract
{
    public abstract class AuditAble : IAuditAble
    {
        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get ; set ; }
        [MaxLength(256)]
        public string CreatedBy { get ; set ; }
        public DateTime? UpdatedDate { get ; set ; }
        [MaxLength(256)]
        public string UpdatedBy { get ; set ; }
    }
}
