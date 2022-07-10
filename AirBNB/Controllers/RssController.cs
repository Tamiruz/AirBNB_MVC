using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class RssController : ApiController
    {

        public IEnumerable<string> Get()
        {
            XMLServices xmls = new XMLServices();
            return xmls.ReadRss();
        }

    }
}
