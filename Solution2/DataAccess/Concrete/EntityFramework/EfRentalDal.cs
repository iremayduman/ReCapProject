using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public bool CheckIfCarIsAvailable(int carId)
        {
            using (CarContext context = new CarContext())
            {
                return (!context.Set<Rental>().Any(r => r.CarId == carId && r.ReturnDate == null));
            }
        }
    }
}
