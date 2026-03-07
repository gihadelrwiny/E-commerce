using EcommCore.Entites.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommCore.interfaces
{
    public interface IcatogeryRepository : IgenericRepository<Category>
    {
        // هنا ممكن اضيف اي دوال خاصة بالكيتوجري غير اللي في الجينيريك

    }
}
