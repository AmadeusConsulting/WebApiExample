using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiExample.Api.v1.Models;

namespace WebApiExample.Api.v1.Controllers
{
    [RoutePrefix("api/v1/customer/{customerId}/order")]
    public class CustomerOrderController : ApiController
    {
        /// <summary>
        /// Get all orders for a customer.
        /// </summary>
        [HttpGet]
        [Route("")]
        [ResponseType(typeof(ICollection<Order>))]
        public HttpResponseMessage Get(int customerId)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new List<Order>());
        }

        /// <summary>
        /// Get an order for a customer.
        /// </summary>
        [HttpGet]
        [Route("{id:int}")]
        [ResponseType(typeof(Order))]
        public HttpResponseMessage Get(int customerId, int id)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new Order());
        }

        /// <summary>
        /// Create an order for a customer.
        /// </summary>
        [HttpPost]
        [Route("")]
        [ResponseType(typeof(Order))]
        public HttpResponseMessage Post(int customerId, Order value)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new Order());
        }

        /// <summary>
        /// Update an order for a customer
        /// </summary>
        [HttpPut]
        [Route("{id:int}")]
        [ResponseType(typeof(Order))]
        public HttpResponseMessage Put(int customerId, int id, Order value)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new Order());
        }

        /// <summary>
        /// Partially update an order for a customer.
        /// </summary>
        [HttpPatch]
        [Route("{id:int}")]
        [ResponseType(typeof(Order))]
        public HttpResponseMessage Patch(int customerId, int id, Order value)
        {
            // Perhaps we haven't implemented the ability to partially update an order, but we plan to...
            return Request.CreateResponse(System.Net.HttpStatusCode.NotImplemented);
        }

        /// <summary>
        /// Delete an order for a customer.
        /// </summary>
        [HttpDelete]
        [Route("{id:int}")]
        public HttpResponseMessage Delete(int customerId, int id)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK);
        }
    }
}
