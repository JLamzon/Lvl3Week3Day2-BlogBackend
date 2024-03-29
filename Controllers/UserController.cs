using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models;
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
        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] LoginDTO User){
            return _data.Login(User);
        }


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
        [HttpPut]
        [Route("UpdateUser")]

        public bool UpdateUser(UserModel userToUpdate){
            return _data.UpdateUser(userToUpdate);
        }


        [HttpPut]
        [Route("UpdateUser/{id}/{username}")]
        public bool UpdateUser(int id, string username){
            return _data.UpdateUsername(id, username);
        }


        //DeleteUser endpoint
        [HttpDelete]
        [Route("DeleteUser/{userToDelete}")]
        public bool DeleteUser(string userToDelete){
            return _data.DeleteUser(userToDelete);
        }


        [HttpGet]
        [Route("GetUserByUsername/{username}")]
        public UserIdDTO GetUserByUsername(string username){
            return _data.GetUserIdDTOByUsername(username);
        }

    }
}