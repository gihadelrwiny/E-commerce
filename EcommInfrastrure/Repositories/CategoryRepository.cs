using EcommCore.Entites.product;
using EcommCore.interfaces;
using EcommInfrastrure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommInfrastrure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, IcatogeryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
