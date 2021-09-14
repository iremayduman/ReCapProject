using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.IEntities
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetByBrandId(int brandId);
        List<Car> GetByColorIdId(int colorId);
        List<Car> GetByUnityPrice(decimal min, decimal max);

        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailsDto> GetCarsDetail();
    }
}
