using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return _carDal.GetCarDetail();
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c => c.CarId == carId);
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>3 && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else if (car.CarName.Length>=3 && car.DailyPrice<=0)
            {
                Console.WriteLine("Günlük kira bedeli 0'dan büyük olmalı.");
            }
            else
            {
                Console.WriteLine("Araba ismi minimum 3 karakter olmalıdır.");
            }

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
