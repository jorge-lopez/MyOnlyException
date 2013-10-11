using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    class MyException : Exception
    {
        private string _Message;

        public MyException()
            : base() 
        {
            _Message = "Exception handled";
        }
        public MyException(string message)
            : base (message)
        {
            _Message = message;
            
        }
 
        public override string Message
        {
           
            get
            {
                return _Message;
            }

        }

    }
}
