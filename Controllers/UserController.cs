using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models.DTO;
using Lvl3Week3Day2_BlogBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lvl3Week3Day2_BlogBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly UserService _data;

        public UserController(UserService data){
            _data = data;
        }
        

        //Login Endpoint

        //AddUser endpoint
            //if user already exists
            //if user does not exist, create new account
            //else return false

            [HttpPost]
            [Route("AddUser")]
            public bool AddUser(CreateAccountDTO UserToAdd){
                return _data.AddUser(UserToAdd);
            }

        //UpdateUser endpoint

        //DeleteUser endpoint

    }
}