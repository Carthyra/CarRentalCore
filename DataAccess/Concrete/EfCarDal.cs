using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete
{
    public class EfCarDal:EfEntityRepositoryBase<Car,CarRentalContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var joinresult = from c in context.Cars
                    join b in context.Brands on c.BrandId equals b.BrandId
                    join co in context.Colors on c.ColorId equals co.ColorId
                    select new CarDetailDto()
                    {
                        CarName = c.CarName,
                        BrandName = b.BrandName,
                        ColorName = co.ColorName
                    };
                return joinresult.ToList();
            }
        }
    }
}
