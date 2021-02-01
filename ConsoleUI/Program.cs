using System;
using ReCapBusiness.Concrete;
using ReCapDataAccess.Abstract;
using ReCapDataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ICarManager carManager = new ICarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId+ " numbered car is " + car.Description + " and Model year: " + car.ModelYear);
            }

        }
    }
}
