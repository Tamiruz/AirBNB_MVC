using AirBNB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AirBNB.Controllers
{
    public class ReservationController : ApiController
    {

        [HttpGet]
        [Route("api/Reservations/{currentUserID}")]
        // GET api/<controller>/5
        public List<Reservation> getReservation(int currentUserID)
        {
            Reservation r = new Reservation();
            User u = new User(currentUserID);
            return r.getAllUserReservations(currentUserID);
        }
        /*
        [HttpPost]
        [Route("api/Reservations/insertReservation/{apartmentID}/{hostId}/{id}/{from}/{to}/{minNights}/{maxNights}/{price}/{apartmentName}")]
        public int Post(int apartmentID, int hostId, int id, string from, string to, int minNights, int maxNights, int price, string apartmentName)
        {
            Apartment a = new Apartment(minNights, maxNights, price, apartmentName);
            Reservation r = new Reservation(id, from, to, apartmentID, apartmentName, hostId, price);

            return r.reserveApartment(a);
        }*/

        [HttpPost]
        [Route("api/Reservations/insertReservation")]
        public int Post([FromBody]Reservation r)
        {
            return r.reserveApartment();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        [Route("api/Reservations/cancelReservation")]
        public int Delete([FromBody] Reservation r)
        {
            return r.cancelReservation();
        }
    }
}