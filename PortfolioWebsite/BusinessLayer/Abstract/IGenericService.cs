using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T parameter);
        void TDelete(T parameter);
        void TUpdate(T parameter);
        List<T> TGetList();
        T TGetById(int id);
    }
}
