using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageAPI.Interfaces;
using MessageAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageAPI.Controllers
{
    [Route("api/User/")]
    [ApiController]
    public class UserController : ControllerBase
    {
       

        [Route("GetUserById/{id}")]
        [HttpGet]
        public ActionResult<USER> GetUserById(Int64 id,[FromServices] IUserRepository _user)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                USER user = _user.GetUserById(id);

                if(user != null)
                {
                    return Ok(user);
                }
                else
                {
                  return  BadRequest(null);
                }               
            }
        }

        [Route("GetListUser")]
        [HttpGet]
        public ActionResult<List<USER>> GetListUsers([FromServices] IUserRepository _user)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                return Ok(_user.GetListUser());
            }
        }

        [Route("CreateUser")]
        [HttpPost]
        public ActionResult<Int64> CreateUser([FromBody]USER user,
                                              [FromServices] IUserRepository _user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                Int64 id = _user.CreateUser(user);
                if (id > 0)
                {
                    return Ok(id);
                }
                else
                {
                    return BadRequest(0);
                }
            }
        }
    }
}
