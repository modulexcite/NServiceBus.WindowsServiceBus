namespace NServiceBus
{
	using Transports;
	using Unicast.Transport;

	/// <summary>
	/// Transport definition for WindowsServiceBus    
	/// </summary>
	public class WindowsServiceBus : TransportDefinition
	{
		public WindowsServiceBus()
		{
			this.HasNativePubSubSupport = true;
			this.HasSupportForCentralizedPubSub = true;
		}
	}
}