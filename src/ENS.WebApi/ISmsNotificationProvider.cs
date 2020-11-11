using ENS.WebApi.Channels;

namespace ENS.WebApi
{
    public interface ISmsNotificationProvider
    {
        void Send(Notification notification);
    }
}