using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    [Serializable]
    class InnerExceptionClassDemo : Exception
    {
        public InnerExceptionClassDemo(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
