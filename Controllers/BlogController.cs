using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lvl3Week3Day2_BlogBackend.Models;
using Lvl3Week3Day2_BlogBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lvl3Week3Day2_BlogBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        
        private readonly BlogService _data;

        public BlogController(BlogService data){
            _data = data;
        }


        [HttpPost]
        [Route("AddBlogItem")]
        public bool AddBlogItem(BlogItemModel newBlogItem){
            return _data.AddBlogItem(newBlogItem);
        }
        

        [HttpGet]
        [Route("GetAllBlogItems")]
        public IEnumerable<BlogItemModel> GetAllBlogItems(){
            return _data.GetAllBlogItems();
        }

        [HttpGet]
        [Route("GetItemsByUserId/{userId}")]
        public IEnumerable<BlogItemModel> GetItemsByUserId(int userId){
            return _data.GetItemsByUserId(userId);
        }


        [HttpGet]
        [Route("GetItemsByCategory/{category}")]
        public IEnumerable<BlogItemModel> GetItemsByCategory(string category){
            return _data.GetItemsByCategory(category);
        }

        [HttpGet]
        [Route("GetPublishedItems")]
        public IEnumerable<BlogItemModel> GetPublishedItems(){
            return _data.GetPublishedItems();
        }


        [HttpGet]
        [Route("GetItemsByDate/{date}")]
        public IEnumerable<BlogItemModel> GetItemByDate(string date){
            return _data.GetItemsByDate(date);
        }

        [HttpGet]
        [Route("GetAllItemsByTags/{tag}")]
        public List<BlogItemModel> GetAllItemsByTags(string tag){
            return _data.GetAllItemsByTags(tag);
        }

        [HttpGet]
        [Route("GetBlogItemById/{id}")]
        public BlogItemModel GetBlogItemById(int id){
            return _data.GetBlogItemById(id);
        }

        [HttpPut]
        [Route("UpdateBlogItem")]
        public bool UpdateBlogItem(BlogItemModel blogUpdate){
            return _data.UpdateBlogItem(blogUpdate);
        }


        [HttpDelete]
        [Route("DeleteBlogItem")]
        public bool DeleteBlogItem(BlogItemModel blogToDelete){
            return _data.DeleteBlogItem(blogToDelete);
        }


        
    }
}