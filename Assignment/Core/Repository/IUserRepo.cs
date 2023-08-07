using Assignment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Core.Repository
{
    public interface IUserRepo
    {
        protected User GetUserByUserName(string username);
        string GetUserRole(string username);
        bool Login(string username,string password);
    }
}
