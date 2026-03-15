using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal : IGenericDal<Customer>//sen IGenericDal dan miras al(bu bir T değeri bekliyordu onu da yazdık(entity yani)) ve 
    {
        //buraya customera özel operasyonlar eklenebilir
        List<Customer> GetCustomerListWithJob();

    }
}
