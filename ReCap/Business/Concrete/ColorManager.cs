using Business.Abstarct;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        EfColorDal _efColorDal;

        public ColorManager(EfColorDal efColorDal)
        {
            _efColorDal = efColorDal;
        }

        public void Add(Color color)
        {
            _efColorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _efColorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _efColorDal.GetAll();
        }
        public void Update(Color color)
        {
            _efColorDal.Update(color);
        }
    }
}
