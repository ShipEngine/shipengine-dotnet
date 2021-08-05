using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ShipEngineException : Exception
{
    [JsonPropertyName("request_id")]
    public string? RequestId { get; }

    [JsonPropertyName("errors")]
    public List<Error> Errors { get; set; }


    public ShipEngineException(string requestID, List<Error> errors) : base(errors[0].Message)
    {
        RequestId = requestID;
        Errors = new List<Error>();

        foreach (Error error in errors)
        {
            Errors.Add(new Error()
            {
                ErrorSource = error.ErrorSource,
                ErrorType = error.ErrorType,
                ErrorCode = error.ErrorCode,
                Message = error.Message,
            });
        }
    }
}

public class Error
{
    [JsonPropertyName("error_source")]
    public string? ErrorSource { get; set; }

    [JsonPropertyName("error_type")]
    public string? ErrorType { get; set; }

    [JsonPropertyName("error_code")]
    public string? ErrorCode { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}