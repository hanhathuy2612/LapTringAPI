using _5951071031_Ha_Nhat_Huy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071031_Ha_Nhat_Huy.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var weatherInfList = new List<StudentInfo>();


           
                var weatherInfo = new StudentInfo
                {
                    Hoten = "Ha Nhat Huy",
                    MaSoSv = "5951071031",
                    Lop = "CQ.CNTT.K59",
                    NgaySinh = new DateTime(2000, 06, 25)
                };
                weatherInfList.Add(weatherInfo);
            
            
            return weatherInfList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo {
                Hoten = "Ha Nhat Huy",
                MaSoSv = "5951071031",
                Lop = "CQ.CNTT.K59",
                NgaySinh = new DateTime(2000, 06, 25)
            };
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
