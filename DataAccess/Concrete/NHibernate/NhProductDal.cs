using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product { ID = 1, Name = "Laptop - NHibernate" },
                new Product { ID = 2, Name = "Mouse - NHibernate" },
                new Product { ID = 3, Name = "Asdf - NHibernate" },
                new Product { ID = 4, Name = "Gfdsa - NHibernate" }
            };
        }
    }
}
