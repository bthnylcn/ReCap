using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }

}
