using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using EmployeeInfoAngularPart2.Models;

namespace EmployeeInfoAngularPart2.Controllers
{


    public class EmployeeController : ApiController
    {
        #region automated code
        //// GET: api/Employee
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Employee/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Employee
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Employee/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Employee/5
        //public void Delete(int id)
        //{
        //}
        #endregion
        private EmployeeCJ2Entities myEntity = new EmployeeCJ2Entities();
        public IEnumerable<EmployeeDB> Get()
        {
            return myEntity.EmployeeDBs.AsEnumerable();
        }

    }
    }

