using System;

namespace MoviesCRUD.Models
{
    public class MovieReview
    {
        public int ID { get; set; } 

        public int MovieID { get; set; } 
        public decimal Score { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Comment { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
