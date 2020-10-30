namespace ENS.WebApi
{
    public interface IUserService
    {
        public string GetName();
    }

    public sealed class UserService : IUserService
    {
        public string GetName()
        {
            return "Mr. Twister";
        }
    }
}
