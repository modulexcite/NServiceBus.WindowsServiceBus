namespace NServiceBus.Unicast.Queuing.WindowsServiceBus
{
	using Transports;

	/// <summary>
	/// Creates the queues. Note that this class will only be invoked when running in the windows host.
	/// </summary>
	public class WindowsServiceBusQueueCreator : ICreateQueues
	{
		public ICreateQueueClients CreateQueueClients { get; set; }

		public void CreateQueueIfNecessary( Address address, string account )
		{
			CreateQueueClients.Create( address );
		}
	}
}