using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(User user)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<User>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<User> GetById(int userId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<User> GetByMail(string email)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }

}
