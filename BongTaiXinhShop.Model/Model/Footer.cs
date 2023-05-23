using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BongTaiXinhShop.Model.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }
        [Required] // Không được để trống
        public string Content { get; set; }
    }
}
