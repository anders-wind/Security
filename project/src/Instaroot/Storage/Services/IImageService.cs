﻿using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Services
{
    public interface IImageService
    {
        Task<IEnumerable<Image>> GetImages();
        Task<Image> GetImage(int id);
        Task PostImage(Image image);
        Task PutImage(Image image);
    }
}
