using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BongTaiXinhShop.Model.Model
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Thuộc tính tự động tăng
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}
