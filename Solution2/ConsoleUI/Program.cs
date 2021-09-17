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
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //var result = rentalManager.Add(new Rental() { Id = 1, CarId = 3, CustomerId = 4, RentDate = DateTime.Now.Date, ReturnDate = null });
            //if (result.Success == true)
            //{
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            //var result1 = rentalManager.Add(new Rental() { Id = 6, CarId = 9, CustomerId = 4, RentDate = DateTime.Now.Date, ReturnDate = new DateTime(2021,9,16) });
            //if (result1.Success == true)
            //{
            //    Console.WriteLine(result1.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result1.Message);
            //}
            var result2 = rentalManager.Add(new Rental() { Id = 8, CarId = 9, CustomerId = 4, RentDate = DateTime.Now.Date, ReturnDate = null });
            if (result2.Success == true)
            {
                Console.WriteLine(result2.Message);
            }
            else
            {
                Console.WriteLine(result2.Message);
            }

        }

        //private static void Car(CarManager carManager)
        //{
        //    carManager.Add(new Car
        //    {
        //        Id = 7,
        //        BrandId = 2,
        //        ColorId = 2,
        //        ModelYear = 2020,
        //        DailyPrice = 400,
        //        Description = "Renault, 2021 Model"
        //    });

        //    carManager.Update(new Car
        //    {
        //        Id = 7,
        //        BrandId = 3,
        //        ColorId = 3,
        //        ModelYear = 2021,
        //        DailyPrice = 500,
        //        Description = "Ford, 2021 Model"
        //    });

        //    Console.WriteLine("---------------------------------");
        //    foreach (var cars in carManager.GetAll())
        //    {
        //        Console.WriteLine(cars.Description + "\n");
        //    }

        //    Console.WriteLine("-----------------------------------");

        //    foreach (var car in carManager.GetByBrandId(3))
        //    {
        //        Console.WriteLine(car.Description + " : " + car + "\n");
        //    }
        //    Console.WriteLine("--------------------------------------");
        //    foreach (var car in carManager.GetByUnityPrice(20, 800))
        //    {
        //        Console.WriteLine(car.Description + " : " + car.BrandId + "\n");
        //    }
        //}
    }
}
