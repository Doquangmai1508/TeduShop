using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public interface ISEOAble
    {
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
    }
}
