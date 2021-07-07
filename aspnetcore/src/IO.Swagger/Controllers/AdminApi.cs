/*
 * Lopez Calculator API
 *
 * This is a simple API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: al08583@georgiasouthern.edu
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class AdminApiController : ControllerBase
    { 
        /// <summary>
        /// Creates a resource
        /// </summary>
        /// <remarks>Adds an item to the system</remarks>
        /// <param name="body">Inventory item to add</param>
        /// <response code="201">item created</response>
        /// <response code="400">invalid input, object invalid</response>
        /// <response code="409">an existing item already exists</response>
        [HttpPost]
        [Route("/alexalpz/LopezCalculatorAPI/1.0.0/calculator")]
        [ValidateModelState]
        [SwaggerOperation("AddsNumber")]
        public virtual IActionResult AddsNumber([FromBody]InventoryItem body)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes values
        /// </summary>
        /// <remarks>By passing in the appropriate options, you can search for available inventory in the system </remarks>
        /// <param name="num1">Passing first number</param>
        /// <param name="operation">Operation for values</param>
        /// <param name="num2">Passing second number</param>
        /// <response code="200">search results matching criteria</response>
        /// <response code="400">bad input parameter</response>
        [HttpDelete]
        [Route("/alexalpz/LopezCalculatorAPI/1.0.0/calculator")]
        [ValidateModelState]
        [SwaggerOperation("DeletesNumber")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<InventoryItem>), description: "search results matching criteria")]
        public virtual IActionResult DeletesNumber([FromQuery][Required()]int? num1, [FromQuery][Required()][Range(0, 50)]int? operation, [FromQuery]int? num2)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<InventoryItem>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"releaseDate\" : \"2016-08-29T09:12:33.001Z\",\n  \"name\" : \"Widget Adapter\",\n  \"id\" : \"d290f1ee-6c54-4b01-90e6-d701748f0851\",\n  \"manufacturer\" : {\n    \"phone\" : \"408-867-5309\",\n    \"name\" : \"ACME Corporation\",\n    \"homePage\" : \"https://www.acme-corp.com\"\n  }\n}, {\n  \"releaseDate\" : \"2016-08-29T09:12:33.001Z\",\n  \"name\" : \"Widget Adapter\",\n  \"id\" : \"d290f1ee-6c54-4b01-90e6-d701748f0851\",\n  \"manufacturer\" : {\n    \"phone\" : \"408-867-5309\",\n    \"name\" : \"ACME Corporation\",\n    \"homePage\" : \"https://www.acme-corp.com\"\n  }\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<InventoryItem>>(exampleJson)
                        : default(List<InventoryItem>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
