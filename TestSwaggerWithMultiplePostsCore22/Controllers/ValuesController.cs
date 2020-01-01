using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestSwaggerWithMultiplePostsCore22.Models;

namespace TestSwaggerWithMultiplePostsCore22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// first post test
        /// </summary>
        /// <param name="firstPostPoco"></param>
        [HttpPost("first-post")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Post1([FromBody] FirstPostPoco firstPostPoco)
        {
        }

        /// <summary>
        /// second post test
        /// </summary>
        /// <param name="secondPostPoco"></param>
        [HttpPost("second-post")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Post2([FromBody] SecondPostPoco secondPostPoco)
        {
        }
    }
}
