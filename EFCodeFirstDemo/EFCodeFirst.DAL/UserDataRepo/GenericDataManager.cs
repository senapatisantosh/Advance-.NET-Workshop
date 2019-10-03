using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirst.CL.Entity;
using EFCodeFirst.DAL.DBContext;

namespace EFCodeFirst.DAL.UserDataRepo
{
    public class UserDataManager<T> : IGenericDataManager<T> where T:class
    {
        private readonly UserDBContext userDbContext;
        private readonly DbSet<T> genericDbSet;
        public UserDataManager()
        {
            this.userDbContext = new UserDBContext();
            genericDbSet = userDbContext.Set<T>();
        }
        public void CreateUsingRepo(T obj)
        {
            //Logic For Adding the user to the DB Using EF

            genericDbSet.Add(obj);
            userDbContext.SaveChanges();
        }
        public bool DeleteUsingRepo(long id)
        {
            bool flag = false;
            //Retriving The Existing Row
            T obj = genericDbSet.Find(id);

            if (obj != null)
            {
                //Remove the Row in the table
                genericDbSet.Remove(obj);
            }

            //Update the Database
            int result = userDbContext.SaveChanges();

            if (result != 0)
                flag = true;

            return flag;
        }
        public List<T> GetAllUsingRepo()
        {
            List<T> objs = genericDbSet.ToList<T>();
            return objs;
        }
        public bool UdpateUsingRepo(T obj)
        {

            //bool flag = false;
            //T objTemp = genericDbSet.Find(obj.UserId);

            //if (objTemp != null)
            //{
            //    //Change the State
            //    userDbContext.Entry(obj).State = EntityState.Modified;
            //}

            ////Update the Database 
            //int result = userDbContext.SaveChanges();

            //if (result != 0)
            //    flag = true;

            //return flag;
            throw new NotImplementedException();
        }
    }
}
