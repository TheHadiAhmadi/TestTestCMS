using MediatR;

namespace TestTestCMS.Providers.MessageBusProviders;

public interface IMessageHandler<TPayload> : INotificationHandler<Message<TPayload>>
{
}
