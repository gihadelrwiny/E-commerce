using EcommCore.interfaces;
using EcommInfrastrure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommCore.interfaces;
using EcommInfrastrure.Data;
using EcommCore.Entites.product;

namespace EcommInfrastrure.Repositories
{
    public class ProductRepository : GenericRepository<Product>,IproductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
