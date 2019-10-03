using EFCodeFirst.CL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.BL
{
    public interface IGenericManager<T> where T:class
    {
        void Create(T obj);
        List<T> GetAll();
        bool Udpate(T obj);
        bool Delete(long id);
    }
}
