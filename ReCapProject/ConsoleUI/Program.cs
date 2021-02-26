using DataAccess.Concrete.InMemory;
using Business.Concrete;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("Araba ID "+" Araba marka"+" Araba rengi"+" Araba fiyatı"+" Araba açıklama"+" Araba model yılı");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("  " + car.CarId + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Description + " " + car.ModelYear); ;
            }
            Console.WriteLine("--------Actual--Car Id 3--------");
            int id = 3;
            foreach (var car in carManager.GetByCarId(id)) 
            {
                Console.WriteLine(" "+car.CarId+"  "+car.BrandId+" "+car.ColorId+" "+car.DailyPrice+" "+car.Description+" "+car.ModelYear);

            }
            Console.WriteLine("-------------Update----------");
            carManager.Update(new Car {CarId=id,BrandId=3,ColorId=3,DailyPrice=400,Description="Audi",ModelYear=2012 });
            Console.WriteLine("CarId=id,BrandId=3,ColorId=3,DailyPrice=400,Description=Audi,ModelYear=2012");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("  " + car.CarId + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Description + " " + car.ModelYear);

            }
            Console.WriteLine("-------------Add New Car--------------");
            carManager.Add(new Car { CarId = 6, BrandId = 6, ColorId = 6, DailyPrice = 190, ModelYear = 2015, Description = "Volkswagen" });
            Console.WriteLine("CarId = 6, BrandId = 6, ColorId = 6, DailyPrice = 190, ModelYear = 2015, Description = Volkswagen");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("  " + car.CarId + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Description + " " + car.ModelYear);
            }
            id = 4;
            Console.WriteLine("----------Delete-----------");
            carManager.Delete(new Car { CarId = id });
            Console.WriteLine("Delete carId 4");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("  " + car.CarId + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Description + " " + car.ModelYear);
            }
        }
    }
}
