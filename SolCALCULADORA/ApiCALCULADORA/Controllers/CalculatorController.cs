﻿namespace ApiCALCULADORA.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("Add")]
        public int Add([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa + numb;
        }
        [HttpPost]
        [Route("Multiply")]
        public int Multiply([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa * numb;
        }
        [HttpPost]
        [Route("Divide")]
        public int Divide([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa / numb;
        }
        [HttpPost]
        [Route("Subtract")]
        public int Subtract([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa - numb;
        }
    }
}
