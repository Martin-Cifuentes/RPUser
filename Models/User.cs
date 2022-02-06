using System;
using System.ComponentModel.DataAnnotations;

namespace RPUser.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}