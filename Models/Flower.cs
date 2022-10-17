using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flowers.Models // was showing warning because i have not stop the project running 
{
    public class Flower
    {
        public int Id { get; set; }

        [Display(Name = "Flower Name")]
        public string Name { get; set; }

        
        [Display(Name = "Selling Date"), DataType(DataType.Date)]
        public DateTime sellingDate { get; set; }
        public string Color { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int Quantity { get; set; } // did spelling mistake after correcting that i had to again add migration and update database which creates the new initial create 2
        [Display(Name = "Customer Review")]
        public string CustomerReview { get; set; }
    }
}
