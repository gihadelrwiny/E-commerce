using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EcommCore.Entites.product
{
    public class Photo:Baseentity<int>
    {
        public string imagename { get; set; }
        public int productid{ get; set; }
        [JsonIgnore] //--> //prevent circular reference during JSON serialization
        [ForeignKey(nameof(productid))]
            public virtual Product Product { get; set; }

    }
}
