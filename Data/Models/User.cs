namespace RentalApp.Data.Models
{  
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User: BaseModel
    {
        public User()
        {
            this.Properties = new HashSet<Property>();
        }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Phone { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}
