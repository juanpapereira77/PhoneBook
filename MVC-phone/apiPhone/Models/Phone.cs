

namespace apiPhone.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum TypeContact
    {
        Phonenumber,
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
        [Required]
        public TypeContact Type { get; set; }
        [Required]
        public string Contact { get; set; }
    }

}