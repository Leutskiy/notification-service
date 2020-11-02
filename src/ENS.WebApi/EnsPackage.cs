using ENS.WebApi.Channels;
using SimpleInjector;
using SimpleInjector.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENS.WebApi
{
    public class EnsPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            // container.Register<IHandler<SendEmailNotification, Result<Success, Failure>>, SendEmailNotificationHandler>();
            container.Register<ICommandHandler<SendEmailNotification, Result<Success, Failure>>, SendEmailNotificationHandler>();
            container.Register<SendEmailNotificationHandler>();
        }
    }
}
