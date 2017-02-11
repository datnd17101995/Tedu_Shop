﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tedu_Shop.Model.Model
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(256)]
        public string Description { set; get; }

        [MaxLength(500)]
        public string Image { set; get; }

        [MaxLength(500)]
        public string Url { set; get; }

        public int? DisplayOrder { set; get; }
        public bool Status { set; get; }
    }
}