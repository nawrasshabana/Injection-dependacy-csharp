using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myuser.models
{
  public  interface Iuser
    {
        User get(int id);
        List<User> getall();
        void addUser(User u);

        void DeleteUser(int x);
    }
}
