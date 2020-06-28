using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using zad11.DTO;
using zad11.services;


namespace zad11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {

        private readonly EfCustomDbService _context;

        public DoctorsController(EfCustomDbService context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.GetDoctors());
        }

        [HttpPost]
        public IActionResult AddDoctor(DoctorRequest doctorRequest)
        {
            _context.AddDoctor(doctorRequest);
            return Ok();
        }

        [HttpPut]
        public IActionResult ModifyDoctor(DoctorRequest doctorRequest)
        {
            _context.ModifyDoctor(doctorRequest);
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveDoctor(int doctorId)
        {
            _context.RemoveDoctor(doctorId);
            return Ok();
        }
    }
}
