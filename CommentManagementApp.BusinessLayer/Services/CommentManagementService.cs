using CommentManagementApp.BusinessLayer.Interfaces;
using CommentManagementApp.BusinessLayer.Services.Repository;
using CommentManagementApp.BusinessLayer.ViewModels;
using CommentManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommentManagementApp.BusinessLayer.Services
{
    public class CommentManagementService : ICommentManagementService
    {
        private readonly ICommentManagementRepository _repo;

        public CommentManagementService(ICommentManagementRepository repo)
        {
            _repo = repo;
        }

        public async Task<Comment> CreateComment(Comment employeeComment)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCommentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Comment> GetAllComments()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Comment> GetCommentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Comment> UpdateComment(CommentViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
