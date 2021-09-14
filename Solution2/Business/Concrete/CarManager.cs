using Business.Abstract;
using Core.IEntities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("New car added: "+ car.Description);
            }
            else
            {
                Console.WriteLine("Car could not added ");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
           
            
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetByColorIdId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public List<Car> GetByUnityPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public List<CarDetailsDto> GetCarsDetail()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Car updated: " +car.Id);
        }
    }
}
