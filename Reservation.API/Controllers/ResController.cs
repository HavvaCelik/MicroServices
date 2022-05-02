using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Infrastructure;
using ReservationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private IReservationService _reservationService;

        public ResController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
       
        [HttpGet("{id}")]
        public ReservationDTO Get(int id)
        {
            return _reservationService.GetResByBkgNumber(id);
        }
    }
}
