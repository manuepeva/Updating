﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<EMPLOYEESTABLE> Get()
        {
            using (mydbEntities entities = new mydbEntities())
            {
                return entities.EMPLOYEESTABLE.ToList();
            }
        }
    }
}
