using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (CarContext contex = new CarContext())
            {
                var result = from c in contex.Cars
                             join
                             b in contex.Brands on c.BrandId equals b.Id
                             join
                             co in contex.Colors on c.ColorId equals co.Id
                             select new CarDetailsDto
                             {
                                 Description = c.Description,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = (short)c.DailyPrice
                             };

                return result.ToList();
            }
        }
    }
}
