﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        Car GetById(int carId);
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAll();


    }
}
