using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
             new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=200,Description="Skoda",ModelYear=2012 },
             new Car{CarId=2,BrandId=2,ColorId=2,DailyPrice=250,Description="BMW",ModelYear=2008 },
             new Car{CarId=3,BrandId=3,ColorId=3,DailyPrice=300,Description="Mercedes",ModelYear=2014 },
             new Car{CarId=4,BrandId=4,ColorId=4,DailyPrice=150,Description="Ford",ModelYear=2010 },
             new Car{CarId=5,BrandId=5,ColorId=5,DailyPrice=170,Description="Renault",ModelYear=2013 },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByCarId(int CarId)
        {
            return _cars.Where(p => p.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

           
    


