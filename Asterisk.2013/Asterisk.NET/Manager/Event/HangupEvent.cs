namespace AsterNET.Manager.Event
{
	/// <summary>
	/// A HangupEvent is triggered when a channel is hung up.<br/>
	/// It is implemented in channel.c
	/// </summary>
	public class HangupEvent : AbstractChannelEvent
	{
		private int cause;
		private string causeTxt;

		/// <summary>
		/// Get/Set the cause of the hangup.
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
		/// </summary>
		public int Cause
		{
			get { return cause; }
			set { this.cause = value; }
		}
		/// <summary>
		/// Get/Set the textual representation of the hangup cause.
		/// </summary>
		public string CauseTxt
		{
			get { return causeTxt; }
			set { this.causeTxt = value; }
		}

		public HangupEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}