﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(IFormFile file, CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll(Expression<Func<CarImage, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            throw new NotImplementedException();
        }
    }

}
