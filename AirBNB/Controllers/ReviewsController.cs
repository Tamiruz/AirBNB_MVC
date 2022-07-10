using AirBNB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AirBNB.Controllers
{
    public class ReviewsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/Reviews/apartment/{id}")]
        // GET api/<controller>/5
        public List<Review> Get(int id)
        {
            Review r = new Review();
            return r.getAllApartmentReviews(id);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/Reviews/insertReview")]
        public int Post([FromBody] Review r)
        {
            Review.revCounter++;
            r.Id = Review.revCounter;
            if (r.insertReview() == 0)
            {
                Review.revCounter--;
                return 0;
            }
            return 1;
            
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}