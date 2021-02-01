using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;

namespace ReCapDataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=20000, Description= "Comfortable, having airbags", ModelYear = "1990"},
                new Car{CarId=2, BrandId=1, ColorId=2, DailyPrice=50000, Description= "they run primarily on roads", ModelYear = "1990"},
                new Car{CarId=3, BrandId=2, ColorId=2, DailyPrice=80000, Description= "seat one to eight people", ModelYear = "1990"},
                new Car{CarId=4, BrandId=4, ColorId=1, DailyPrice=35000, Description= "have four wheels", ModelYear = "1990"},

            };

          
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
