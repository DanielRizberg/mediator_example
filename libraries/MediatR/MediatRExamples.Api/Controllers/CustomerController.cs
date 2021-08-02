﻿#region Imports
using MediatRExamples.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
#endregion

namespace MediatRExamples.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        #region Members

        private readonly ILogger<CustomerController> _logger;

        #endregion

        #region Ctor

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        #endregion

        #region Methods

        [HttpGet]
        public IActionResult Get()
        {


            return Ok();
        }

        [HttpPost]
        public IActionResult Add(CustomerModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

                // re-render the view when validation failed.
                //return View(model);
            }

            //TODO: Save the data to the database, or some other logic.

            return Ok();
        }

        #endregion
    }
}
