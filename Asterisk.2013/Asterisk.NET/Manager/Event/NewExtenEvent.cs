namespace AsterNET.Manager.Event
{
	/// <summary>
	/// A NewExtenEvent is triggered when a channel is connected to a new extension.<br/>
	/// It is implemented in pbx.c
	/// </summary>
	public class NewExtenEvent : ManagerEvent
	{
		private string context;
		private string extension;
		private int priority;
		private string application;
		private string appData;
		private string appdEvent;

		public string AppdEvent
		{
			get { return this.appdEvent; }
			set { this.appdEvent = value; }
		}

		/// <summary>
		/// Get/Set the name of the application that is executed.
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
		/// </summary>
		public string Application
		{
			get { return this.application; }
			set { this.application = value; }
		}
		/// <summary>
		/// Get/Set the parameters passed to the application that is executed. The parameters are separated by a '|' character.
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
		/// </summary>
		public string AppData
		{
			get { return this.appData; }
			set { this.appData = value; }
		}
		/// <summary>
		/// Get/Set the name of the context of the connected extension.
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
		/// </summary>
		public string Context
		{
			get { return this.context; }
			set { this.context = value; }
		}
		/// <summary>
		/// Get/Set the extension.
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
		/// </summary>
		public string Extension
		{
			get { return this.extension; }
			set { this.extension = value; }
		}
		/// <summary>
		/// Get/Set the priority.
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
		/// </summary>
		public int Priority
		{
			get { return this.priority; }
			set { this.priority = value; }
		}
	
		public NewExtenEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}