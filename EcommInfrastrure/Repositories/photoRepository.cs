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
   public class photoRepository: GenericRepository<Photo>, IphotoRepository
    {
        public photoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
