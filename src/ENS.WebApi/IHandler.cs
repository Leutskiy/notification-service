namespace ENS.WebApi
{
    public interface IHandler<in TIn, out TOut>
    {
        TOut Handle(TIn input);
    }


}
