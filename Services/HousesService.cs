using CSHARP_Gregslist.Models;
using CSHARP_Gregslist.DB;

namespace CSHARP_Gregslist.Services
{
    public class HousesService
    {
        internal List<House> GetAll()
        {
            return FakeDB.Houses;
        }
    }
}