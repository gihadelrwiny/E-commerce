using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace EcommCore.interfaces.Iservice
{
    public interface IimageManagmentService
    {
        Task<List<string>>AddImageAsync(IFormFileCollection files ,string src );
        void DeleteImage(String src);
    }
}
