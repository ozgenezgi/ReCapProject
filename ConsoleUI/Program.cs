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



            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "/" + car.BrandName);
            }
        }
    }
    
}
