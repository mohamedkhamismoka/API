using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebApplication20.BL;
using WebApplication20.BL.VM;
using WebApplication20.DAL.Database;
using WebApplication20.DAL.Entities;

namespace WebApplication20.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCourseController : ControllerBase
    {

        private readonly Iunitofwork uok;
        private readonly IMapper mapper;
        private readonly database db;

        public StudentCourseController(Iunitofwork uok, IMapper mapper,database db)
        {
            this.uok = uok;
            this.mapper = mapper;
            this.db = db;
        }
        [HttpGet("{id}")]
        public IActionResult getStudentDegrees(int id)
        {
            return Ok(uok.studentcourses.Filter(a => a.StudentId == id));
        }

        [HttpGet("{stdid}/{crsid}")]
        public IActionResult get_Student_Degrees_in_Course(int stdid, int crsid)
        {
            return Ok(uok.studentcourses.Filter(a => a.StudentId == stdid && a.courseId == crsid));
        }
        [HttpPost]
        public IActionResult create(studentCourseVM stdcrs)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var cour = mapper.Map<StudentCourse>(stdcrs);
                    uok.studentcourses.create(cour);
                    return Ok("created successfully");
                }
                return BadRequest("please review Data");
            }
            catch (Exception e)
            {
                return BadRequest("please review Data");
            }

        }





        [HttpPut]
        public IActionResult update(studentCourseVM stdcrs)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var cour = mapper.Map<StudentCourse>(stdcrs);
                    uok.studentcourses.update(cour);
                    return Ok("updated successfully");
                }
                return BadRequest("please review Data");
            }
            catch (Exception e)
            {
                return BadRequest("please review Data");
            }

        }

        [HttpDelete(("{stdid}/{crsid}"))]
        public IActionResult Delete(int crsid, int stdid)
        {
            try
            {
               
                db.studentCourses.Remove(db.studentCourses.Where(a => a.courseId == crsid && a.StudentId == stdid).FirstOrDefault());
                db.SaveChanges();
                return Ok("Deleted successfully");
            }
            catch (Exception e)
            {
                return BadRequest("please review Data");
            }

        }
    }
}
