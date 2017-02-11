using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tedu_Shop.Model.Abstract;

namespace Tedu_Shop.Model.Model
{
    [Table("Pages")]
    public class Page : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [Column(TypeName ="Varchar")]
        [MaxLength(256)]
        public string Alias { set; get; }

        public string Content { set; get; }
    }
}