using CSHARP_Gregslist.DB;
using CSHARP_Gregslist.Models;

namespace CSHARP_Gregslist.Services
{
    public class CarsService
    {
        internal List<Car> GetAll()
        {
            return FakeDB.Cars;
            {
                throw new Exception("Unable to get cars");
            }
        }

        internal Car GetById(string carId)
        {
            Car? foundCar = FakeDB.Cars.Find(c => c.Id == carId);
            if (foundCar == null)
            {
                throw new Exception("Unable to find id");
            }
            return foundCar;
        }

        internal Car Create(Car newCar)
        {
            FakeDB.Cars.Add(newCar);
            return newCar;
        }

        internal Car Edit(Car editedCar, string carId)
        {
            Car originalCar = GetById(carId);
            originalCar.Year = editedCar.Year != 0 ? editedCar.Year : originalCar.Year;
            originalCar.Make = editedCar.Make != null ? editedCar.Make : originalCar.Make;
            originalCar.Model = editedCar.Model != null ? editedCar.Model : originalCar.Model;
            originalCar.Price = editedCar.Price != 0 ? editedCar.Price : originalCar.Price;
            originalCar.Description = editedCar.Description != null ? editedCar.Description : originalCar.Description;
            originalCar.ImgUrl = editedCar.ImgUrl != null ? editedCar.ImgUrl : originalCar.ImgUrl;
            return originalCar;
        }

        internal Car Delete(string carId)
        {
            Car foundCar = GetById(carId);
            FakeDB.Cars.Remove(foundCar);
            return foundCar;
        }
    }
}