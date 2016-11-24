using System;

namespace AsterNET.Manager.Event
{
	public class QueueCallerAbandonEvent : ManagerEvent
	{
		private string queue;
		private int position;
		private int originalPosition;
		private int holdTime;
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
		public string Queue
		{
			get { return this.queue; }
			set { this.queue = value; }
		}
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
		public int HoldTime
		{
			get { return this.holdTime; }
			set { this.holdTime = value; }
		}
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
		public int Position
		{
			get { return this.position; }
			set { this.position = value; }
		}
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
		public int OriginalPosition
		{
			get { return this.originalPosition; }
			set { this.originalPosition = value; }
		}
		/// <summary>
		/// Creates a new DNDStateEvent.
		/// </summary>
		public QueueCallerAbandonEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}
