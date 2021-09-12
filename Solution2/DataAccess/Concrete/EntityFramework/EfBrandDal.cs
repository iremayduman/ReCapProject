using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IEntityRepository<Brand>
    {
        public void Add(Brand brand)
        {
            using (CarContext context = new CarContext())
            {
                var addedEntity = context.Entry(brand);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand brand)
        {
            using (CarContext context = new CarContext())
            {
                var addedEntity = context.Entry(brand);
                addedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                return filter == null ? context.Brands.ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public Brand GetBy(Expression<Func<Brand, bool>> filter)
        {
            using (CarContext context = new CarContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public void Update(Brand brand)
        {
            using (CarContext context = new CarContext())
            {
                var updatedEntity = context.Entry(brand);
                updatedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
