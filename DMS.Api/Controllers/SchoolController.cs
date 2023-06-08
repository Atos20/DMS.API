﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DMS.Api;
using DMS.Api.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using DMS.Api.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DMS.Api.Controllers
{
    [Route("api/[controller]")]
    public class SchoolController : Controller
    {
        private readonly ILogger<SchoolController> _logger;
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public SchoolController(DataContext context, IMapper mapper, ILogger<SchoolController> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }
        // GET: api/values
        // should return the information about the Schools register, we need just the  ID and Name
        [HttpGet]
        public async Task<ActionResult<List<School>>> GetSchools()
        {
            try
            {
                var schoolsDTO = _mapper.Map<List<SchoolDTO>>(await _context.School.ToListAsync());
                return Ok(schoolsDTO);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError(ex, "An error occurred while retrieving schools.");

                // Return an appropriate error response
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving schools. Please try again later.");
            }

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

