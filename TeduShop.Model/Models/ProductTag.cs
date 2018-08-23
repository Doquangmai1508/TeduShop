using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("ProductID")]
        public int ProductID { get; set; }
        [ForeignKey("TagID")]
        [Column(Order =2,TypeName = "varchar")]
        [MaxLength(50)]
        [Key]
        public int TagID { get; set; }

        public virtual Product Product  { get; set; }
        public virtual Tag Tag { get; set; }

    }
}
