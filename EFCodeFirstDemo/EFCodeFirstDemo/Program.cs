using EFCodeFirst.BL;
using EFCodeFirst.CL.Entity;
using EFCodeFirstDemo.DenpendencyInjection;
using System;
using System.Linq;
using Unity;

namespace EFCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register the Interface Inside my Unity Container
            IUnityContainer unityContainer = UnityRegistration.Register();


            IGenericManager<User> genericManagerForUser = unityContainer.Resolve<IGenericManager<User>>();
            IGenericManager<Department> genericManagerForDepartment = unityContainer.Resolve<IGenericManager<Department>>();
            //IUserManager userManager = new UserManager();

            User user = genericManagerForUser.GetAll().Where(x=>x.UserId == 1).FirstOrDefault();
            user.DeptID = genericManagerForDepartment.GetAll().Where(x =>x.DepartmentId == 1).FirstOrDefault().DepartmentId;
            genericManagerForUser.Udpate(user);
            Console.ReadKey();
        }
    }
}
