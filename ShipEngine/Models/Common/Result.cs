using ShipEngine.Models;
using ShipEngine.Models.Exceptions;
using System.Linq;

namespace ShipEngine.ConvenienceMethods
{
    public static class ResultExtensions
    {
        public static void AssertNoErrorMessages(this IResult result)
        {
            var Errors = result.Messages.Errors;
            if (Errors.Any())
            {
                throw new ShipEngineException(Errors.Aggregate((a, b) => a + ", " + b));
            }
        }
    };
};