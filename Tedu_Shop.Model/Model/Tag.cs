using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tedu_Shop.Model.Model
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(50)]
        public string Type { set; get; }
    }
}