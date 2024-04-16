namespace Pql.ExpressionEngine.Exceptions;

using System;
using System.Runtime.Serialization;

[Serializable]
public class FormulaEngineException : Exception
{
    public FormulaEngineException()
    {
    }

    public FormulaEngineException(string message) : base(message)
    {
    }

    public FormulaEngineException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected FormulaEngineException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}