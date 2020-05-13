using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOVIEZ_.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string street_address { get; set; }
        public string city_address { get; set; }
        public string state_address { get; set; }
        public int zip_address { get; set; }
        public long phone_address { get; set; }
        public string email_address { get; set; }

    }
}