using System.Linq;

namespace ENS.WebApi
{
    public interface IPermissionFilter<T>
    {
        IQueryable<T> GetPermitted(IQueryable<T> queryable);
    }
}
