using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models;
using Lvl3Week3Day2_BlogBackend.Models.DTO;
using Lvl3Week3Day2_BlogBackend.Services.Context;

namespace Lvl3Week3Day2_BlogBackend.Services
{
    public class UserService
    {

        private readonly DataContext _context;


        public UserService(DataContext context){
            _context = context;
        }


        public bool DoesUserExist(string Username){
            //check if username exist
            // if 1 matches then return the item
            //if no item matches, then return null
            
            //SingleOrDefault is a method from Linq, a language integrated query similar to SQL.  It was introduced my microsoft as part of the .net framework. 
            //This code checks if there is a user in the user information managed by _context whose username matches the provided Username. If such a user is found, it returns true; otherwise, it returns false.
            return _context.UserInfo.SingleOrDefault(user => user.Username == Username) != null;
        }

        public bool AddUser(CreateAccountDTO UserToAdd)
        {
            //if user already exists
            //if does not exist create new account
            //else return false

            bool result = false;

            //if user doesn't exist, add user based on model
            if(!DoesUserExist(UserToAdd.Username)){
                UserModel newUser = new UserModel();
                result = true;
            }


            return result;
        }


    }
}