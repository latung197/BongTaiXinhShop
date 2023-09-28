using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BongTaiXinhShop.Model.Abstract;

namespace BongTaiXinhShop.Model.Model
{
    [Table("ClientCategorys")]
    public class ClientCategory : AudiTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(256)]
        public string Name2 { get; set; }
        [MaxLength(256)]
        [Column(TypeName = "nvarchar")]
        public string Address { get; set; }
        [MaxLength(25)]
        public string Phone { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        [MaxLength(128)]
        public string Fax { get; set; }
        [MaxLength(128)]
        public string Masothue { get; set; }
        [MaxLength(128)]
        public string GroupClient1 { get; set; }
        [MaxLength(128)]
        public string GroupClient2 { get; set; }
        [MaxLength(128)]
        public string GroupClient3 { get; set; }
        [MaxLength(256)]
        [Column(TypeName = "nvarchar")]
        public string Bank { get; set; }
        [MaxLength(128)]
        public string BankAccountNumber { get; set; }
        [MaxLength(128)]
        public string Note { get; set; }

    }
}
