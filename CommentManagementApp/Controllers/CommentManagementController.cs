using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CommentManagementApp.BusinessLayer.Interfaces;
using CommentManagementApp.BusinessLayer.ViewModels;
using CommentManagementApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementApp.Entities;

namespace CommentManagementApp.Controllers
{
    [ApiController]
    public class CommentManagementController : ControllerBase
    {
        private readonly ICommentManagementService  _commentService;
        public CommentManagementController(ICommentManagementService commentservice)
        {
             _commentService = commentservice;
        }

        [HttpPost]
        [Route("create-comment")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateComment([FromBody] Comment model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-comment")]
        public async Task<IActionResult> UpdateComment([FromBody] CommentViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        [HttpDelete]
        [Route("delete-comment")]
        public async Task<IActionResult> DeleteComment(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-comment-by-id")]
        public async Task<IActionResult> GetCommentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-comments")]
        public async Task<IEnumerable<Comment>> GetAllComments()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
