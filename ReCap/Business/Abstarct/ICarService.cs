using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByBrandId(int brandId);
        List<Car> GetByColorId(int colorId);
        List<CarDetailDto> GetCarDetail();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
