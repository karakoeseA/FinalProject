﻿using Business.Abstract;
using DataAccess0.Abstract;
using DataAccess0.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class ProductManager:IProductService
    {       
            IProductDal _productDal;

        public ProductManager(IProductDal productDal) 
        {        
         _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
