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
    public class ValuesController : ControllerBase
    {
        Iuser Nawras = null;

        public ValuesController(Iuser first)
        {
            this.Nawras = first;
        }
        [HttpGet]
        public List<User> getall()
        {
            return Nawras.getall();
        }

        [HttpGet("{id}")]
        public User get(int id)
        {
            return Nawras.get(id);
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
                Nawras.addUser(u);
        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            Nawras.DeleteUser(id);

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

