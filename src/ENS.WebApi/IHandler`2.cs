using System;
using System.Linq;

namespace ENS.WebApi
{
    public interface IHandler<in TIn, out TOut>
    {
        TOut Handle(TIn input);
    }

    public interface IQuery<out TOut>
    {
    }

    public interface ICommand<out TOut>
    {
    }

    public interface IQueryHandler<in TIn, out TOut> : IHandler<TIn, TOut>
        where TIn : IQuery<TOut>

    {
    }

    public interface ICommandHandler<in TIn, out TOut> : IHandler<TIn, TOut>
        where TIn : ICommand<TOut>
    {
    }

    public abstract class HandlerDecoratorBase<TIn, TOut> : IHandler<TIn, TOut>
    {
        protected readonly IHandler<TIn, TOut> Decarated;
        public HandlerDecoratorBase(IHandler<TIn, TOut> decorared)
        {
            this.Decarated = decorared;
        }

        public abstract TOut Handle(TIn input);
    }

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
        }

        public TResult Match<TResult>(
            Func<TSuccess, TResult> success,
            Func<TFailure, TResult> failure)
        {
            return _isSuccess ? success(_success) : failure(_failure);
        }
    }

    public interface IPermissionFilter<T>
    {
        IQueryable<T> GetPermitted(IQueryable<T> queryable);
    }


}
