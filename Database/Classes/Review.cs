using System;
using System.Collections.Generic;
using System.Text;

namespace hotel_booking.Database.Classes
{
    public class Review
    {
        public int reviews_id { get; set; }
        public int user_id { get; set; }
        public int hotel_id { get; set; }
        public int rating_int { get; set; }
        public string review_str { get; set; }
        public DateTime createDate_date { get; set; }
    }
}
