using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myuser.models
{
    public class UserServices :Iuser
    {
        List<User> us = new List<User>()
        {
            new User() { id = 1000, name = "ali", email = "ali@gmail.com", phone = "0098", date = "2021/09/23" },
            new User() { id = 1001, name = "basel", email = "basel@gmail.com", phone = "0123", date = "2021/09/23" },
            new User() { id = 1002, name = "samar", email = "samar@gmail.com", phone = "0981", date = "2021/09/23" },
            new User() { id = 1003, name = "mohamad", email = "mohamad@gmail.com", phone = "0093", date = "2021/09/23" },
            new User() { id = 1004, name = "zyan", email = "zyan@gmail.com", phone = "1241", date = "2021/09/23" },

        };
        [HttpPost]
        public void addUser([FromBody] User u)
        {
            us.Add(u);
        }
        [HttpDelete("{id}")]
        public void DeleteUser(int x)
        {
            var delus = us.SingleOrDefault(item => item.id == x);
            if (delus != null)
                us.Remove(delus);

        }
        [HttpGet("{id}")]
        public User get(int id)
        {
            return us.SingleOrDefault(item => item.id == id);
        }
        [HttpGet]
        public List<User> getall()
        {
            return us;
        }
    }
}
