using EcommCore.Entites.product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommCore.DTO
{
    //make DTO better than jsonignore to prevent circular reference during JSON serialization
    public record ProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal price { get; set; }
       
        
        public string CategoryName { get; set; }
        public ICollection<PhotoDTO> Photos { get; set; }
    }
    public record PhotoDTO
    {
        public string imagename { get; set; }
        public int productid { get; set; }

    }
}
