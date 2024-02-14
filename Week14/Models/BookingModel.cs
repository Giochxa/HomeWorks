using Microsoft.AspNetCore.DataProtection;
using System;

namespace Week14.Models
{
    public class BookingModel
    {
        //public int PersonId { get; set; }
        //public string Name { get; set; }
        //public string Gender { get; set; }
        //public string City { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Doctor { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
    }
}
