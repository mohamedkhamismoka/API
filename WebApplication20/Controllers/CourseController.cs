using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication20.BL;
using WebApplication20.BL.VM;
using WebApplication20.DAL.Entities;

namespace WebApplication20.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly Iunitofwork uok;
        private readonly IMapper mapper;

        public CourseController(Iunitofwork uok, IMapper mapper)
        {
            this.uok = uok;
            this.mapper = mapper;
        }
        [HttpGet]
       
        public IActionResult getAll()
        {
            return Ok(uok.courses.GetAll());
        }


        [HttpPut]

        public IActionResult Update(CourseVM crs)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var cour = mapper.Map<Course>(crs);
                    uok.courses.update(cour);
                    return Ok("Updated successfully");
                }
                return BadRequest("please review Data");
            }
            catch (Exception e)
            {
                return BadRequest("please review Data");
            }
        }


        [HttpPost]

        public IActionResult Create(CourseVM crs)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var cour = mapper.Map<Course>(crs);
                    uok.courses.create(cour);
                    return Ok("created successfully");
                }
                return BadRequest("please review Data");
            }
            catch (Exception e)
            {
                return BadRequest("please review Data");
            }
        }



        [HttpDelete("{id}")]
   
        public IActionResult Delete(int id)
        {


            uok.courses.delete(id);
            return Ok("Deleted sucessfully");


        }




        [HttpGet("{id}")]
      
        public IActionResult Getbyid(int id)
        {
            return Ok(uok.courses.getbyid(id));
        }


    }
}
