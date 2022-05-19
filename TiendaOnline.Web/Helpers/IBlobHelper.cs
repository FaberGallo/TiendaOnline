﻿namespace TiendaOnline.Web.Helpers
{

    using Microsoft.AspNetCore.Http;
    using System;
    using System.Threading.Tasks;

    public interface IBlobHelper
    {
        Task<Guid> UploadBlobAsync(IFormFile file, string containerName);

        Task<Guid> UploadBlobAsync(byte[] file, string containerName);

        Task<Guid> UploadBlobAsync(string image, string containerName);
    }

}
