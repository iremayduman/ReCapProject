using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.IEntities
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorIdId(int colorId);
        IDataResult<List<Car>> GetCarsByUnityPrice(decimal min, decimal max);
        IDataResult<List<CarDetailsDto>> GetCarsDetail();
    }
}
