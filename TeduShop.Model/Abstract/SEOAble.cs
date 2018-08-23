using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public class SEOAble : ISEOAble
    {
        [MaxLength(256)]
        public string MetaKeyword { get ; set ; }
        [MaxLength(256)]
        public string MetaDescription { get ; set ; }
    }
}
