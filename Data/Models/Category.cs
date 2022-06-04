namespace RentalApp.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category:BaseModel
    {
        public Category()
        {
            this.Properties = new HashSet<Property>();
        }
        [Required]
        public string Type { get; set; }
        public ICollection<Property> Properties { get; set; }
    }
}
