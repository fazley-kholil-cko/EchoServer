using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EchoServer.Controllers
{
    public class EchoController : Controller
    {
        [Route("")]
        public IActionResult Root()
        {
            try
            {
                return Ok(Environment.MachineName);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [Route("echo")]
        public IActionResult Echo()
        {
            try
            {
                //string getEnv = Environment.GetEnvironmentVariable("envVar");
                return Ok(Environment.MachineName);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [Route("env")]
        public IActionResult Env()
        {
            try
            {
                string getEnv = Environment.GetEnvironmentVariable("version");
                return Ok(getEnv);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }
    }
}