using GestaoVeiculos.Exceptions.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoVeiculos.Exceptions
{
    public class MarcaException : Exception
    {
        public MarcaErrorCode ErrorCode { get;}
        public MarcaException(string? message) : base(message)
        {   
        }
        public MarcaException(string? message, MarcaErrorCode errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
