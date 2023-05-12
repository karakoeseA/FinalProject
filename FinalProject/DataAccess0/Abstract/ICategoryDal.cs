using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess0.Abstract
{
    public interface ICategoryDal:IEntitiyRepository<Categorys>
    {
        List<Product> GetAll();
        
        void add(Product product);

        void Update(Product product);

        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);

    }
}
