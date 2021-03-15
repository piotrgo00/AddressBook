using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica"), Required(ErrorMessage = "Pole obowiazkowe"), StringLength(30, MinimumLength = 5)]
        public string Street { get; set; }

        [Required]
        public int Number { get; set; }

        public string ZipCode { get; set; }
        public string City { get; set; }
    }
}
