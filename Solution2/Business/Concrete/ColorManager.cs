using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Color Get(int id)
        {
            return _colorDal.GetBy(c => c.Id == id);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
    }
}
