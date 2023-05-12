﻿using Business.Concrete;
using System;


namespace ConsoleUI
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            ProductManager productManager =new ProductManager(new  InMemoryProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.Name);
            }

        }
    }


}
