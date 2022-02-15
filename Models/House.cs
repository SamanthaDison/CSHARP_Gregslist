
using System.ComponentModel.DataAnnotations;

namespace CSHARP_Gregslist.Models
{
    public class House
    {
        public string? Id { get; set; }
        [Required]
        public string? Address { get; set; }
        public int Sqft { get; set; }
        public int Rooms { get; set; }
        public double Bathrooms { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }


        public House(string? address, int sqft, int rooms, double bathrooms, int price, string? description, string? imgUrl)
        {
            Id = Guid.NewGuid().ToString();
            Address = address;
            Sqft = sqft;
            Rooms = rooms;
            Bathrooms = bathrooms;
            Price = price;
            Description = description;
            ImgUrl = imgUrl;
        }


    }
}