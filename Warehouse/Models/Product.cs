using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Warehouse.Models
{
    public class Product         //- en poko, blir en tabell
    {
        public int    Id          { get; set; }  //-Namnet Id anger att det är primärnyckel

        [Required]
        [StringLength(100,MinimumLength = 3)]
        public string Name        { get; set; }

        [Range(0,int.MaxValue, ErrorMessage ="The price can't be less than zero")] //- Värdeomfång för Price
        public int    Price       { get; set; }
        public string Category    { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "The price can't be less than zero")] //- Värdeomfång
        public int    Count       { get; set; }

        [Display(Name= "Product Description")]  //-styr vad display skall titta efter
        public string Description { get; set; }


    }
}