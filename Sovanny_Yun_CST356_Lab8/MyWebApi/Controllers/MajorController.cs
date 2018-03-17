using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sovanny_Yun_CST356_Lab3.Data;
using Sovanny_Yun_CST356_Lab3.Data.Entities;

namespace MyWebApi.Controllers
{
    [RoutePrefix("api/Majors")]
    public class MajorController : ApiController
    {

        private AppDbContext _dbContext;

        public MajorController()
        {
            _dbContext = new AppDbContext();
        }

        [HttpGet]
        public IEnumerable<Major> GetAllMajors()
        {
            return _dbContext.Majors.ToList();
        }

        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult GetMajors(int id)
        {
            var major = _dbContext.Majors.FirstOrDefault((p) => p.Id == id);
            if (major == null)
            {
                return NotFound();
            }
            return Ok(major);
        }
    }
}
