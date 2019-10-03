using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class MyCustomException : ApplicationException
    {
        public MyCustomException()
        {
        }

        public MyCustomException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        public MyCustomException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine($"Message : {message} and InnerException : {innerException}");
        }

        protected MyCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            Console.WriteLine($"SerializationInfo : {info} and StreamingContext : {context}");
        }
    }
}
