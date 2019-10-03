using EFCodeFirst.CL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.DAL.UserDataRepo
{
    public interface IGenericDataManager<T> where T:class
    {
        void CreateUsingRepo(T obj);
        List<T> GetAllUsingRepo();
        bool UdpateUsingRepo(T obj);
        bool DeleteUsingRepo(long id);
    }
}
