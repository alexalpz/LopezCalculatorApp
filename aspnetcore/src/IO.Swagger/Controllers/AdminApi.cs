/*
 * Lopez Calculator API
 *
 * This is a simple API
 *
 * OpenAPI spec version: 2.0.0
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
        /// <param name="num1">Passing first number</param>
        /// <param name="num2">Passing second number</param>
        /// <param name="add">Adds two integers</param>
        /// <param name="subtract">Subtracts two integers</param>
        /// <param name="multiply">Multiplies two integers</param>
        /// <param name="divide">Divides two integers</param>
        /// <param name="power">Raises power of two integers</param>
        /// <response code="200">search results matching criteria</response>
        /// <response code="400">bad input parameter</response>
        [HttpPost]
        [Route("/alexalpz/LopezCalculatorAPI/2.0.0/")]
        [ValidateModelState]
        [SwaggerOperation("AddsNumber")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Calculator>), description: "search results matching criteria")]
        public virtual IActionResult AddsNumber([FromQuery]int? num1, [FromQuery]int? num2, [FromQuery]string add, [FromQuery]string subtract, [FromQuery]string multiply, [FromQuery]string divide, [FromQuery]string power)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Calculator>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ \"\", \"\" ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Calculator>>(exampleJson)
                        : default(List<Calculator>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Deletes values
        /// </summary>
        /// <remarks>By passing in the appropriate options, you can search for available inventory in the system </remarks>
        /// <param name="num1">Passing first number</param>
        /// <param name="num2">Passing second number</param>
        /// <param name="add">Adds two integers</param>
        /// <param name="subtract">Subtracts two integers</param>
        /// <param name="multiply">Multiplies two integers</param>
        /// <param name="divide">Divides two integers</param>
        /// <param name="power">Raises power of two integers</param>
        /// <response code="200">search results matching criteria</response>
        /// <response code="400">bad input parameter</response>
        [HttpDelete]
        [Route("/alexalpz/LopezCalculatorAPI/2.0.0/")]
        [ValidateModelState]
        [SwaggerOperation("DeletesNumber")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Calculator>), description: "search results matching criteria")]
        public virtual IActionResult DeletesNumber([FromQuery]int? num1, [FromQuery]int? num2, [FromQuery]string add, [FromQuery]string subtract, [FromQuery]string multiply, [FromQuery]string divide, [FromQuery]string power)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Calculator>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ \"\", \"\" ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Calculator>>(exampleJson)
                        : default(List<Calculator>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
