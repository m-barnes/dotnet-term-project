using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MOVIEZ_.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public string street_address { get; set; }
        [Required]

        public string city_address { get; set; }
        [Required]
        [StringLength(2)]

        public string state_address { get; set; }
        [Required]

        public int zip_address { get; set; }
        [Required]
        public long phone_address { get; set; } 
        public string email_address { get; set; }
        public DateTime? birthdate { get; set; }
        public bool IsSubscribed { get; set; }

        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership")]
        public byte MembershipTypeId { get; set; }

    }
}