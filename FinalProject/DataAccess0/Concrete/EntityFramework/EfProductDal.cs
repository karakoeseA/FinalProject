using DataAccess0.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess0.Concrete.EntityFramework
{
    public class EfProductDal : ICategoryDal
    {
        public void add(Product product)
        {
            throw new NotImplementedException();
        }

        public void add(Categorys entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Categorys entitiy)
        {
            throw new NotImplementedException();
        }

        public Categorys Get()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Categorys> GetAll(Expression<Func<Categorys, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Categorys entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
