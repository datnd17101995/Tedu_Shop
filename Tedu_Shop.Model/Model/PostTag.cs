using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tedu_Shop.Model.Model
{
    [Table("PostTag")]
    public class PostTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { set; get; }

        [Key]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Posts { set; get; }

        [ForeignKey("tags")]
        public virtual Tag Tags { set; get; }
    }
}