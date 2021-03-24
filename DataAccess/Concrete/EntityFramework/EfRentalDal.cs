using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDbContext>, IRentalDal
    {
        public List<CarRentalDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var result = from rent in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join car in context.Cars on rent.CarId equals car.Id
                             join col in context.Colors on car.ColorId equals col.Id
                             join brd in context.Brands on car.BrandId equals brd.Id
                             join cus in context.Customers on rent.CustomerId equals cus.Id
                             join user in context.Users on cus.UserId equals user.Id
                             select new CarRentalDetailDto
                             {
                                 RentalId = rent.Id,
                                 CustomerName = user.FirstName,
                                 CustomerLastName = user.LastName,
                                 CustomerCompanyName = cus.CompanyName,
                                 CarName = car.Description,
                                 BrandName = brd.Name,
                                 ColorName = col.Name,
                                 DailyPrice = car.DailyPrice,
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
