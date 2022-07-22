using Business.Abstarct;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        EfBrandDal _efBrandDal;

        public BrandManager(EfBrandDal efBrandDal)
        {
            _efBrandDal = efBrandDal;
        }

        public void Add(Brand brand)
        {
            _efBrandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _efBrandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _efBrandDal.GetAll();
        }
        public void Update(Brand brand)
        {
            _efBrandDal.Update(brand);
        }
    }
}
