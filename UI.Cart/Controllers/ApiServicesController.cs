﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UI.Cart.Controllers
{
    public class ApiServicesController : ApiController
    {
        // GET: api/ApiServices
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ApiServices/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ApiServices
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ApiServices/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiServices/5
        public void Delete(int id)
        {
        }
    }
}
