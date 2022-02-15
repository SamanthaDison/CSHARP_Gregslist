using CSHARP_Gregslist.Models;

namespace CSHARP_Gregslist.DB
{
    public class FakeDB
    {
        public static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car (1965, "Volkswagen", "Van", 34000, "van lyfe", "https://i.pinimg.com/originals/98/ae/e1/98aee1597b7e045f62a22bf514e92676.jpg" ),
            new Car (2013, "Porsche", "Cayenne", 75000, "it goes vroom", "http://www.blogcdn.com/www.autoblog.com/media/2012/09/lead2-2013-porsche-cayenne-diesel-fd.jpg"  ),
            new Car (2020, "Subaru", "Forester", 35000, "subie gang", "https://www.carprousa.com/hubfs/car-review-blog/review_337095_1.jpg")
        };

        public static List<House> Houses { get; set; } = new List<House>()
        {
            new House("1234 Main St", 2100, 4, 3.5, 450000, "Comfortable sized single-family home", "https://webassetsprdnvrsan.blob.core.windows.net/images/f0b7d0fd-1451-4299-9e86-8b3c83de0a05/desktop/thumbnail" ),
            new House("4567 S Clearwater Ln", 4500, 5, 4.5, 750000, "Newly renovated mid-century modern home with bonus room", "https://images.dwell.com/photos/6257422372108419072/6451435078668066816/large.jpg" ),
            new House("8672 E Carlton Bay Apt 201", 700, 1, 1, 1100, "Luxury studio apartment with full amenities", "https://rentpath-res.cloudinary.com/w_336,h_280,t_rp,cs_tinysrgb,fl_force_strip,c_fill/e_unsharp_mask:50,q_auto/4f472736377fa6fb7879d102ab1b7997"),
         };
    }
}