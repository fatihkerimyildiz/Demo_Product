using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ProductManager : IGenericService<Product> //şimdi bunların Producttaki repositorylere erişmesi gerekiyor bunun için constructer metot kullanacağız(istediğimiz atamayı yapabilmek için)
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public void TRemove(Product t)
        {
            _productDal.Delete(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
