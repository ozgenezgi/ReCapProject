using System;
using ReCapBusiness.Concrete;
using ReCapDataAccess.Abstract;
using ReCapDataAccess.Concrete.EntityFramework;
using ReCapDataAccess.Concrete.InMemory;
using ReCapEntities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();

        }

        private static void CarTest()
        {
            ICarManager carManager = new ICarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {

                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + "/" + " " + car.BrandName + " " + car.Description + " Car color: " + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
    
}
