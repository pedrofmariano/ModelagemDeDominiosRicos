using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.DomainObjects {
    public class DomainException: Exception 
    {
        public DomainException() 
        {  }

        //Passa uma menssagem personalizada
        public DomainException(string message) : base(message) 
        {  }

        //Passa a mensagem e a Exception interna
        public DomainException(string message, Exception innerException) : base(message, innerException) 
        { }
    }
}
