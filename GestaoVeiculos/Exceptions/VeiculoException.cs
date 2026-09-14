using GestaoVeiculos.Exceptions.Enums;

namespace GestaoVeiculos.Exceptions;

public class VeiculoException : Exception
{
    public VeiculoErrorCode ErrorCode { get; }

    public VeiculoException(string? message) : base(message)
    {
    }
    public VeiculoException(string? message, VeiculoErrorCode errorCode) : base(message)
    {
        ErrorCode = errorCode;
    }
}