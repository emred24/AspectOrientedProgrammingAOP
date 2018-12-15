using Business.Abstract;
using Business.Concrete;
using Core.Caching;
using Core.CrossCuttingConcerns;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ioc Container
            IProductService productService = new ProductManager(new NhProductDal());

            foreach (var product in productService.GetAll())
            {
                Console.WriteLine($"ID : {product.ID} - Name : {product.Name}");
            }
            Console.ReadLine();
        }
    }
}
