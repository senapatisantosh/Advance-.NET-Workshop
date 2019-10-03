using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace EFCodeFirstDemo.DenpendencyInjection
{
    public class UnityRegistration
    {
        public static IUnityContainer Register()
        {

            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.LoadConfiguration();
            return unityContainer;
        }
    }
}
