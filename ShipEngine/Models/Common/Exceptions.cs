using System;
using System.Collections.Generic;

namespace ShipEngine.Models.Exceptions
{
    [Serializable]
    public class ShipEngineException : Exception
    {
        public int Code
        {
            get;
        }

        public readonly Dictionary<string, object>? Details;

        public ShipEngineException(string message) : base(message)
        {
        }

        public ShipEngineException(string message, int errorCode, Dictionary<string, object>? data) : base(message)
        {
            Code = errorCode;
            Details = data;
        }

    }
}