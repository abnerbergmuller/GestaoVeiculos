using GestaoVeiculos.Models;
using GestaoVeiculos.Presenters;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using Npgsql;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace GestaoVeiculos.Exceptions;

public class BancoException : Exception
{
    public DateTime DataHora { get; }

    public string Mensagem { get; }

    public string LocalErro { get; }

    public string? CodigoErro { get; }

    public string? RastroCodigo { get; }

    public BancoException(string? message) : base(message)
    {
    }
    
    public BancoException(string? message, DateTime dataHora, string mensagem, string? codigoErro, string? rastroCodigo) : base(message)
    {
        DataHora = dataHora;
        Mensagem = mensagem;
        CodigoErro = codigoErro;
        RastroCodigo = rastroCodigo;
    }

    private static string RetornaNomeConstraint(string nomeConstraint)
    {
        if (nomeConstraint.Contains("marca"))
        {
            return nomeConstraint.Replace("ck_marca_", "").Replace("uq_marca_", "");
        }
        else if (nomeConstraint.Contains("veiculo"))
        {
            return nomeConstraint.Replace("ck_veiculo_", "").Replace("uq_veiculo_", "");
        }
        return nomeConstraint;
    }

    private static BancoException MontarBancoException(string mensagemAmigavel, PostgresException pgEx)
    {
        return new BancoException(mensagemAmigavel, DateTime.Now,
            pgEx.MessageText,
            pgEx.SqlState, pgEx.StackTrace);
    }

    public static Exception Validar(PostgresException pgEx)
    {
        switch (pgEx.SqlState)
        {
            case PostgresErrorCodes.NotNullViolation:
                return MontarBancoException($"O campo '{pgEx.ColumnName}' não pode ser nulo.", pgEx);
            case PostgresErrorCodes.CheckViolation:
                if (!pgEx.ConstraintName.Contains("ano"))
                {
                    if (pgEx.ConstraintName.Contains("marca_id"))
                    {
                        return MontarBancoException($"O veículo deve possuir uma marca válida.", pgEx);
                    }
                    return MontarBancoException($"O campo '{RetornaNomeConstraint(pgEx.ConstraintName)}' é obrigatório.", pgEx);
                }
                else return MontarBancoException($"O ano do veículo deve ser entre 1950 e {DateTime.Today.Year.ToString(CultureInfo.InvariantCulture)}.", pgEx);
            case PostgresErrorCodes.UniqueViolation:
                return MontarBancoException($"Já existe um registro com este(a) {RetornaNomeConstraint(pgEx.ConstraintName)}.", pgEx);
            case PostgresErrorCodes.StringDataRightTruncation:
                return MontarBancoException($"Um dos campos ultrapassou o limite de caracteres permitido.", pgEx);
            case PostgresErrorCodes.ForeignKeyViolation:
                return MontarBancoException($"Não é possível excluir marcas com veículos cadastrados, faça a exclusão na tela de Veículos primeiro.", pgEx);
            default:
                return null;
        }
    }
}