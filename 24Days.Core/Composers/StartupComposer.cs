using _24Days.Core.NotificationsHandlers;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Notifications;

namespace _24Days.Core.Composers
{
    internal class StartupComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder
                .AddNotificationHandler<ServerVariablesParsingNotification,
                    ServerVariablesParsingNotificationHandler>();
        }
    }
}
