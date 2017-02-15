﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ForumAPI.Data;
using Newtonsoft.Json;
using ForumAPI.Models;
using ForumAPI.Utilities;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ForumAPI.Controllers
{
    /// <summary>
    /// Controller that returns information about threads, which includes the
    /// posts when requesting a single thread.
    /// </summary>
    [Route("api/[controller]")]
    public class ThreadsController : Controller
    {
        private ForumContext database; 

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Thread thread = database.GetThread(id);
            if (thread == null)
            {
                return Errors.NoSuchElement;
            }
            return JsonConvert.SerializeObject(thread);
        }

        // POST api/values/5
        [HttpPost]
        public void Post([FromBody]string session, [FromBody]Thread thread)
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
