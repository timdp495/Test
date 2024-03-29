/*
 * Product API
 *
 * Move your app forward with the Product API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class ProductsApiController : Controller
    { 

        /// <summary>
        /// Product Types
        /// </summary>
        /// <remarks>The Products endpoint returns information about the *Uber* products offered at a given location. The response includes the display name and other details about each product, and lists the products in the proper display order. </remarks>
        /// <param name="latitude">Latitude component of location.</param>
        /// <param name="longitude">Longitude component of location.</param>
        /// <response code="200">An array of products</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/v1/products")]
        [SwaggerOperation("ProductsGet")]
        [SwaggerResponse(200, type: typeof(List<Product>))]
        public virtual IActionResult ProductsGet([FromQuery]double? latitude, [FromQuery]double? longitude)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Product>>(exampleJson)
            : default(List<Product>);
            return new ObjectResult(example);
        }
    }
}
