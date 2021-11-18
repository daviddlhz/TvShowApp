using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class TvShow
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Title { get; set; }
        [Required]
        public Genre Genre {get; set; }
        [Required]
        [DisplayFormat(DataFormatString ="{0:0.0#}")]
        public decimal Rating { get; set; }
        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "Imdb Link")]
        public string ImdUrl { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name ="Poster")]
        public string ImgUrl { get; set; }

    }
}
