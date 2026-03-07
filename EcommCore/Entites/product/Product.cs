using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommCore.Entites.product
{
    public class Product:Baseentity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal price { get; set; }
            public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
            public virtual Category Category { get; set; }
        public ICollection<Photo> Photos { get; set; }

    }
}
