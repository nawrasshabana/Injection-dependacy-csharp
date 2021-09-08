using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using myuser.Controllers.models;
using myuser.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myuser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        Iuser depInjec = null;

        public UserController(Iuser Iu)
        {
            this.depInjec = Iu;
        }
        [HttpGet]
        public List<User> getall()
        {
            return depInjec.getall();
        }

        [HttpGet("{id}")]
        public User get(int id)
        {
            return depInjec.get(id);
        }
        /*
            public void put([FromBody] User USRRR)
            {
            Nawras.Adduser(USRRR);

            }
        */
        [HttpPost]
        public void addUser([FromBody] User u)
        {
            depInjec.addUser(u);
        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            depInjec.DeleteUser(id);

        }
        /*
        [HttpPut]
        public IActionResult UpdateUser(int id, [FromBody] User USRRR)
        {
            var ouser = us.SingleOrDefault(x => x.id == id);
            if (ouser == null)
            {
                return NotFound("No Found");
            }
            ouser.name = USRRR.name;
            ouser.email = USRRR.email;
            ouser.phone = USRRR.phone;
            ouser.date = USRRR.date;
            //   us.Add(ouser);
            /*
               if (us.Count == 0)
               {
                   return NotFound("No List found");
               }
               return Ok(us);
            */
        //  retun Ok(us); 
        //  return Ok(us);
        //}

    }
    }

