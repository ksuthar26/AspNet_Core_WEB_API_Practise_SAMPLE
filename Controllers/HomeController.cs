using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIControllers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WEB_API_SAMPLE.Controllers
{
    // [ApiController]
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    //[Produces("application/json")]
    public class HomeController : MyControllerBase
    {

        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        /// <param name="id"></param>  
        [HttpGet("{id?}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
             nameof(DefaultApiConventions.Get))]
        public string Index(int id)
        {
            //throw new ArgumentException($"Throwing Error");

            return "API Running...";
        }


        /// <summary>
        /// Creates a reservation.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        /// <param name="reservation"></param>
        /// <returns>A newly created reservation</returns>
        /// <response code="201">Returns the newly created reservation</response>
        /// <response code="400">If the reservation is null</response> 
        [HttpPost]
        [Route("[action]")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
             nameof(DefaultApiConventions.Post))]
        public ActionResult<Reservation> MakeReservation([FromBody] Reservation reservation)
        {



            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
                //return ValidationProblem(ModelState);
            }

            Reservation Reservation = new Reservation();

            //return Reservation;

            return NotFound();

        }

        [HttpPost]
        [Consumes("application/json")]
        public IActionResult PostJson(IEnumerable<int> values)
        {
            return Ok(new { Consumes = "application/json", Values = values });
        }

        //[HttpPost]
        //[Consumes("application/x-www-form-urlencoded")]
        //public IActionResult PostForm([FromForm] IEnumerable<int> values)
        //{
        //    return Ok(new { Consumes = "application/x-www-form-urlencoded", Values = values });
        //}

        // GET api/authors/version
        [HttpGet("version")]
        public string Version()
        {
            return "Version 1.0.0";
        }

        [HttpGet("About")]
        public ContentResult About()
        {
            return Content("An API listing authors of docs.asp.net.");
        }

        // GET api/authors/RickAndMSFT
        [HttpGet("CCC/{alias}")]
        [Produces("application/xml")]
        public Reservation Get(string alias, string dd)
        {
            return new Reservation();
            //return null;
        }

        [HttpGet("analy/{alias}")]
        public IActionResult Get(string alias)
        {
            if (string.IsNullOrEmpty(alias))
            {
                return NotFound();
            }

            return Ok(new Reservation());
        }

        [HttpGet("{format?}")]
        [FormatFilter]
        public Reservation Get(bool alias)
        {
            return new Reservation();
            //return null;
        }

        //[Route("[action]")]
        //public ActionResult<Reservation> MakeReservation1(Reservation reservation, Reservation reservation1)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //        //return ValidationProblem(ModelState);
        //    }

        //    Reservation Reservation = new Reservation();

        //    return Reservation;
        //}
    }
}