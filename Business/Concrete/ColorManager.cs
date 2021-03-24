using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(Color color)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<Color>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Color> GetById(int colorId)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Color color)
        {
            throw new System.NotImplementedException();
        }
    }

}
