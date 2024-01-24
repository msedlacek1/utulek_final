using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualniUtulek.Eshop.Application.Abstraction
{
    public interface IFileUploadService
    {
        Task<string> FileUploadAsync(IFormFile fileToUpload, string folderNameOnServer);
    }
}
