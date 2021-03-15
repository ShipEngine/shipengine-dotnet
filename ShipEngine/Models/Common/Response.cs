using ShipEngine.Models;
using ShipEngine.Models.Exceptions;

namespace ShipEngine.ConvenienceMethods
{

    public static class ResponseExtensions
    {


        public static T UnwrapResultOrThrow<T>(this IResponse<T> response) where T : IResult
        {
            var err = response.Error;
            var result = response.Result;

            if (err != null)
            {
                // On a fatal user OR server error -- for example, the server was unabrle to harndle the results
                throw new ShipEngineException(err.Message ?? "Unknown RPC error", err.Code, err.Data);
            }
            else if (result == null) // JSON RPC contract violation: Result/Error are mutually exclusive.
            {
                throw new ShipEngineException("Invalid response; result missing");
            }
            result.AssertNoErrorMessages();
            return result;
        }
    };
};