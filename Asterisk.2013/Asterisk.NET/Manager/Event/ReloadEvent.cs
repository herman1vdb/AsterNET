namespace AsterNET.Manager.Event
{
	/// <summary>
	/// A ReloadEvent is triggerd when the reload console command is executed or the asterisk server is started.<br/>
	/// It is implemented in manager.c
	/// </summary>
	public class ReloadEvent : ConnectionStateEvent
	{
		private string message;
		private string module;
		private string status;

		/// <summary>Reload event status.
        /// <br/> <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.</summary>
		public string Status
		{
			get { return this.status; }
			set { this.status = value; }
		}
		/// <summary> Returns
		/// "Manager"
		/// "Enum"
		/// "DNSmgr"
		/// "CDR"
        /// <br/> <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
		/// </summary>
		public string Module
		{
			get { return this.module; }
			set { this.module = value; }
		}
		/// <summary> Returns
		/// "Reload Requested",
		/// "ENUM reload Requested",
		/// "DNSmgr reload Requested",
		/// "CDR subsystem reload requested"
		/// .</summary>
		public string Message
		{
			get { return this.message; }
			set { this.message = value; }
		}

		public ReloadEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}