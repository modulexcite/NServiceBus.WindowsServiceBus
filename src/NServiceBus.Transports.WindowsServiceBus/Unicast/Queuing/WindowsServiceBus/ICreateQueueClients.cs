using Microsoft.ServiceBus.Messaging;

namespace NServiceBus.Unicast.Queuing.WindowsServiceBus
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICreateQueueClients
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        QueueClient Create(Address address);
    }
}
