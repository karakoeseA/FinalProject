using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess0.Abstract
{
    public interface IEntitiyRepository<T>
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null );

        T Get();
        void add(T entitiy);

        void Update(T entitiy);

        void Delete(T entitiy);

        
    }
}
