using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert(T t);
        void TRemove(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetById(int id);
    }
}
