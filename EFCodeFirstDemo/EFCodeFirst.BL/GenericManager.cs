using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirst.CL.Entity;
using EFCodeFirst.DAL.UserDataRepo;

namespace EFCodeFirst.BL
{
    internal class GenericManager<T> : IGenericManager<T> where T:class
    {
        private readonly IGenericDataManager<T> userDataManager;
        public GenericManager(IGenericDataManager<T> userDataManager)
        {
            //this.userDataManager = new UserDataManager();
            this.userDataManager = userDataManager;
        }

        public void Create(T obj)
        {
            userDataManager.CreateUsingRepo(obj);
        }

        public bool Delete(long id)
        {
            return userDataManager.DeleteUsingRepo(id);
        }

        public List<T> GetAll()
        {
            return userDataManager.GetAllUsingRepo();
        }

        public bool Udpate(T obj)
        {
            return userDataManager.UdpateUsingRepo(obj);
        }
    }
}
