using System;
using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime FoundateDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
