using EcommCore.interfaces.Iservice;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommCore.Services
{
    internal class imageManagmentService : IimageManagmentService
    {
        private readonly IFileProvider fileprovider;
        public imageManagmentService(IFileProvider _file)
        {
            fileprovider = _file;
        }
        public async Task<List<string>> AddImageAsync(IFormFileCollection files, string src)
        {
           var savedimages=new List<string>();
           var ImageDirectory=Path.Combine("wwwroot", "images",src);
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                  var imageName=file.FileName;
                    var imagesrc=$"images/{src}/{imageName}";
                    var root=Path.Combine(ImageDirectory,imageName);
                   using (var stream = new FileStream(root, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    savedimages.Add(imagesrc);

                }
            }
            return savedimages;
        }

        public void DeleteImage(string src)
        {
            var info=fileprovider.GetFileInfo(src);
            var root = info.PhysicalPath;
            File.Delete(root);
        }
    }
}
