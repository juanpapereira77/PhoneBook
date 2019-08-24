using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_phone.Models
{
    public enum TypeContact
    {   Phonenumber,
        Email,
        Facebook,
        Twitter,
        LinkedIN

    }

    public class Phone
    {
        [key]
 
        public int PhoneID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required ]
        public TypeContact  Type   { get; set; }
        [Required ]
        public string  Contact { get; set; }
    }
}