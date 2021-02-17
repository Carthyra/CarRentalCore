using System;
using Business.Concrete;
using DataAccess.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetByBrandId(4))
            //{
            //    Console.WriteLine(car.CarName +"/"+car.BrandId);
            //}

            foreach (var carDetailDto in carManager.GetCarDetail())
            {
                Console.WriteLine(carDetailDto.CarName+"/"+carDetailDto.BrandName+"/"+carDetailDto.ColorName);
            }
        }
    }
}
