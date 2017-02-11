using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tedu_Shop.Model.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}