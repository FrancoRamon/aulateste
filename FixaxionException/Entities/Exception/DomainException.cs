using System;
using System.Collections.Generic;
using System.Text;

namespace FixationException.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
  
        }
    }
}
