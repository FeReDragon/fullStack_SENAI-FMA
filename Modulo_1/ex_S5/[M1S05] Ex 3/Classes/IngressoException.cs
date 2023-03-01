using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _M1S05__Ex_3.Classes
{
    public class IngressoException : Exception
    {
        public IngressoException(string message) : base(message)
        {
            
        }
        public IngressoException(string message, Exception causaException) : base(message, causaException)
        {

        }
    }
}