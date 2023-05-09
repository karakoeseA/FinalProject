using DataAccess0.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess0.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return new List<Product> { new Product { ProductName ="Tablo" },new Product {ProductName ="su" } };
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
