using System;

namespace AsterNET.Manager.Event
{
	public class OriginateResponseEvent : ResponseEvent
	{
		private string response;
		private string context;
		private string exten;
		private int reason;
		private string callerIdNum;
		private string callerIdName;
		private string callerId;
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>

		public string Response
		{
			get { return this.response; }
			set { this.response = value; }
		}
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>

		public string Context
		{
			get { return this.context; }
			set { this.context = value; }
		}
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>

		public string Exten
		{
			get { return this.exten; }
			set { this.exten = value; }
		}
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>

		public int Reason
		{
			get { return this.reason; }
			set { this.reason = value; }
		}
		public string CallerId
		{
			get { return callerId; }
			set { callerId = value; }
		}
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>

		public string CallerIdNum
		{
			get { return this.callerIdNum; }
			set { this.callerIdNum = value; }
		}
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>

		public string CallerIdName
		{
			get { return this.callerIdName; }
			set { this.callerIdName = value; }
		}

		public OriginateResponseEvent(ManagerConnection source)
			: base(source)
		{
		}

	}
}
