using AirBNB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AirBNB.Controllers
{
    public class FavoritesController : ApiController
    {
        // GET api/<controller>/5
        [HttpGet]
        [Route("api/Favorites/getAllApartmentsFavorites/{userId}")]
        public List<Apartment> GetApartments(int userId)
        {
            Favorite f = new Favorite();
            return f.getAllApartmentsFavorites(userId);
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("api/Favorites/getAllFavorites")]
        public List<Favorite> Get(int userId)
        {
            Favorite f = new Favorite();
            return f.getAllFavorites(userId);
        }

        [HttpPost]
        [Route("api/Favorites/insertFavorite")]
        // POST api/<controller>
        public int Post([FromBody]Favorite f)
        {
            return f.insertFavorite();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        [Route("api/Favorites/deleteFromFavorites")]
        public List<Favorite> Delete([FromBody]Favorite f)
        {
            return f.deleteFromFavorite();
        }
    }
}