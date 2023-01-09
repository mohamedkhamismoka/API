using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System;
using WebApplication20.BL;
using WebApplication20.DAL.Entities;
using WebApplication20.BL.VM;
using AutoMapper;
using WebApplication20.BL.services;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication20.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
  
    
  
    public class StudentController : ControllerBase
    {
        private readonly Iunitofwork unw;
        private readonly IMapper mapper;
   

        public StudentController(Iunitofwork unw,IMapper mapper)
        {
            this.unw = unw;
            this.mapper = mapper;
      
        }
    [HttpGet]
    
        public IActionResult GetAll()
        {
            var data=unw.students.GetAll();
            return Ok(data);
        }

        [HttpPost]


     
        public IActionResult Create([FromHeader] StudentVm std)
        {
            try
            {
                if (ModelState.IsValid)
                {
             
                    var imgname = fileuploader.upload("images", std.img);
                    std.imgName = imgname;
                    var data = mapper.Map<Student>(std);
                    unw.students.create(data);
                    return Ok("student Added Successfully");

                }
                return BadRequest("please,Review Data");

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPut]
      
        public IActionResult update(StudentVm std)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    fileuploader.delete(std.imgName);
                    var imgname = fileuploader.upload("images", std.img);
                    std.imgName = imgname;
                    var data = mapper.Map<Student>(std);
                    unw.students.update(data);
                    return Ok("updated successfully");

                }
                return BadRequest("please,Review Data");

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        
        public IActionResult Delete(int id)
        {
            try
            {
                unw.students.delete(id);
                return Ok("Deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("{id}")]
       
        public IActionResult Details(int id)
        {
            try
            {
                var data=unw.students.getbyid(id);
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
