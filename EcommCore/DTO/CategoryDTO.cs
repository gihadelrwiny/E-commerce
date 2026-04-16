using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommCore.DTO
{
    public  record CategoryDTO
    (string name,string description);
    public record UpdateCategoryDTO
    (string name, string description,int id);

}
