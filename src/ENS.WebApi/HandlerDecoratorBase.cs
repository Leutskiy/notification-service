namespace ENS.WebApi
{
    public abstract class HandlerDecoratorBase<TIn, TOut> : IHandler<TIn, TOut>
    {
        protected readonly IHandler<TIn, TOut> Decarated;
        public HandlerDecoratorBase(IHandler<TIn, TOut> decorared)
        {
            this.Decarated = decorared;
        }

        public abstract TOut Handle(TIn input);
    }


}
