﻿using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using Web.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class AccountSourcesController : Controller
    {
        public AccountSourcesController(GroltyFinancesWebContext dbContext)
        {
            DbContext = dbContext;
        }

        [FromServices]
        private GroltyFinancesWebContext DbContext { get; }

        // GET: api/values
        [HttpGet]
        public IEnumerable<AccountSource> Get()
        {
            return DbContext.AccountSources;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}