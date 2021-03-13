using ShipEngine.Models.JsonRpc;

namespace ShipEngine.Models
{
    public interface IResponse<T> where T : IResult
    {
        public string Id
        {
            get;
        }

        public T? Result
        {
            get; set;
        }

        public JsonRpcResponseErrorData? Error
        {
            get; set;
        }
    }

}