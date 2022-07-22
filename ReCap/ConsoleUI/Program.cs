using Business.Concrete;
using System;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetail())
            {
                Console.WriteLine("isim :"+item.CarName+"\nmarka:"+item.BrandName+"\nrenk :"+item.ColorName+"\ngünlük fiyat :"+item.DailyPrice);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color { Id = 2, Name = "Turuncu" };
            colorManager.Delete(color);
            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand { Id = 2, Name = "BMW" };
            brandManager.Delete(brand);
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //Car newCar = new Car {Id=1,BrandId=1,ColorId=1,ModelYear=2023,DailyPrice=600,CarName="Togg",Detail="Yerli SUV TOGG" };
            //carManager.Add(newCar);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
