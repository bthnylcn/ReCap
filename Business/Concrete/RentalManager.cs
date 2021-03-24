using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Rental rental)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<CarRentalDetailDto>> GetRentalDetails()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Rental rental)
        {
            throw new System.NotImplementedException();
        }
    }

}
