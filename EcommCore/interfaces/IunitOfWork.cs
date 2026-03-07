using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommCore.interfaces
{
    public interface IunitOfWork
    {
        public IcatogeryRepository catogeryRepository { get;  }
        public IproductRepository productRepository { get; }
        public IphotoRepository photoRepository { get; }
    }
}
