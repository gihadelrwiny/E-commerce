using EcommCore.interfaces;
using EcommInfrastrure.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommInfrastrure.Repositories
{
    public class UnitOfWork : IunitOfWork
    {
        private readonly AppDbContext _context;
        public IcatogeryRepository catogeryRepository { get; }

        public IproductRepository productRepository { get; }

        public IphotoRepository photoRepository { get; }
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            catogeryRepository = new CategoryRepository(_context);
            productRepository = new ProductRepository(_context);
            photoRepository = new photoRepository(_context);
        }
    }
}
