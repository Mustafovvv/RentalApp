namespace RentalApp.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Property:BaseModel
    {
        [Required]
        public string PropertyType { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Locarion { get; set; }
        [Required]
        public string RentOrNot { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
