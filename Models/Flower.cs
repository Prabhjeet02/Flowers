using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Flowers.Models // was showing warning because i have not stop the project running 
{
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime sellingDate { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } // did spelling mistake after correcting that i had to again add migration and update database which creates the new initial create 2
        public string CustomerReview { get; set; }
    }
}
