using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            

            
            carManager.Add(new Car
            {
                Id = 7,
                BrandId = 2,
                ColorId = 2,
                ModelYear = 2020,
                DailyPrice = 400,
                Description = "Renault, 2021 Model"
            });

            carManager.Update(new Car
            {
                Id = 7,
                BrandId = 3,
                ColorId = 3,
                ModelYear = 2021,
                DailyPrice = 500,
                Description = "Ford, 2021 Model"
            });

            Console.WriteLine("---------------------------------");
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Description + "\n");
            }

            Console.WriteLine("-----------------------------------");

            foreach (var car in carManager.GetByBrandId(3))
            {
                Console.WriteLine(car.Description + " : " + car.BrandId + "\n");
            }
            Console.WriteLine( "--------------------------------------");
            foreach (var car in carManager.GetByUnityPrice(20,800))
            {
                Console.WriteLine(car.Description + " : " + car.BrandId + "\n");
            }

        }
    }
}
