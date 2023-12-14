using Microsoft.EntityFrameworkCore;
using CommentManagementApp.BusinessLayer.ViewModels;
using CommentManagementApp.DataLayer;
using CommentManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CommentManagementApp.BusinessLayer.Services.Repository
{
    public class CommentManagementRepository : ICommentManagementRepository
    {
        private readonly CommentManagementAppDbContext _dbContext;
        public CommentManagementRepository(CommentManagementAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Comment> CreateComment(Comment CommentModel)
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