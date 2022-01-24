using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    public class User
    {
        public int Id { get; set; }
        
      
      [Required(ErrorMessage ="FirstName is Required")]
        public string FirstName { get; set; }



        [Required(ErrorMessage = "LastName is Required")]
        public string LastName { get; set; }

     
        public string MobileNo { get; set; }


        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        public string AddressLine1 { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        public string  AddressLine2 { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "PostCode is Required")]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "Country is Required")]
        public string Country { get; set; }

    }
}
