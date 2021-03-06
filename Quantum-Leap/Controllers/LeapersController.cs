﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Quantum_Leap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeapersController : ControllerBase
    {
        readonly LeaperRepository _leaperRepositry;

        public LeapersController()
        {
            _leaperRepositry = new LeaperRepository();
        }

        //GET api/Leapers
        [HttpGet]
        public ActionResult GetAllLeapers()
        {
            return Ok(_leaperRepositry.GetAllLeapers());
        }
    }
}