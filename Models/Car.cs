using System.ComponentModel.DataAnnotations;


namespace CSHARP_Gregslist.Models
{
    public class Car
    {
        public string? Id { get; set; }
        [Required]
        public int Year { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }

        public Car(int year, string? make, string? model, int price, string? description, string? imgUrl)
        {
            Id = Guid.NewGuid().ToString();
            Year = year;
            Make = make;
            Model = model;
            Price = price;
            Description = description;
            ImgUrl = imgUrl;
        }
    }
}