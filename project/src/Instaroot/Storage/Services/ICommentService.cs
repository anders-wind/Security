﻿using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Services
{
    public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetComments();
        Task<Comment> GetComment(int id);
        Task PostComment(Comment comment);
        Task PutComment(Comment comment);
    }
}
