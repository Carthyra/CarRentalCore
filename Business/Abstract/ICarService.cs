using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByBrandId(int brandId);
        List<Car> GetByColorId(int colorId);
        List<CarDetailDto> GetCarDetail();
        Car GetById(int carId);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

    }
}
