using System;

namespace ENS.WebApi
{
    public class Result<TSuccess, TFailure>
    {
        private readonly TSuccess _success;
        private readonly TFailure _failure;
        private readonly bool _isSuccess;

        public Result(TSuccess success)
        {
            this._success = success;
            this._isSuccess = true;
        }

        public Result(TFailure failure)
        {
            this._failure = failure;
            this._isSuccess = false;
        }

        public TResult Match<TResult>(
            Func<TSuccess, TResult> success,
            Func<TFailure, TResult> failure)
        {
            return _isSuccess ? success(_success) : failure(_failure);
        }
    }


}
