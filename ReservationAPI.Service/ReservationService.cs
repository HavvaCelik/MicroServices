using ReservationAPI.Infrastructure;
using ReservationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationAPI.Service
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int BkgNumber)
        {
            return new ReservationDTO()
            {
                Id=(new Random()).Next(100),
                Amount=(new Random()).Next(10000),
                BkgDate=DateTime.Now,
                CheckinDate=DateTime.Now.Date.AddDays(30),
                CheckoutDate=DateTime.Now.Date.AddDays(37),
                BkgNumber=BkgNumber
            };
        }
    }
}
