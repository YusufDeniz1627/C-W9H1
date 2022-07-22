using Business.Abstarct;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        EfCarDal _efCarDal;

        public CarManager(EfCarDal efCarDal)
        {
            this._efCarDal = efCarDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>=2 && car.DailyPrice>=0)
            {
                _efCarDal.Add(car);
            }
            else
            {
                Console.WriteLine("Hatalı Bilgiler..");
            }
        }

        public void Delete(Car car)
        {
            _efCarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _efCarDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _efCarDal.GetAll(c=>c.BrandId==brandId);
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _efCarDal.GetAll(c => c.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return _efCarDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _efCarDal.Update(car);
        }
    }
}
