﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdmitereOnline.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AdmitereOnline.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _context;
        public WeatherForecastController(DataContext context)
        {
            _context = context;

        }
        /*
               private static readonly string[] Summaries = new[]
               {
                   "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
               };

               private readonly ILogger<WeatherForecastController> _logger;

               public WeatherForecastController(ILogger<WeatherForecastController> logger)
               {
                   _logger = logger;
               }
       */
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await  _context.Values.ToListAsync();

            return Ok(values);
            
        }

        // GET api/values
        [HttpGet("{id}")]

        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }


    }
}