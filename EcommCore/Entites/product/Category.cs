using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EcommCore.Entites.product
{
    public class Category:Baseentity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public ICollection<Product> Products { get; set; }=new HashSet<Product>();
    }
}
