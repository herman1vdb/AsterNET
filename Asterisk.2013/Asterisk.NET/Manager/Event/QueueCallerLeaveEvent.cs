namespace AsterNET.Manager.Event
{
    /// <summary>
    /// A QueueCallerLeaveEvent is triggered when a channel leaves a queue.<br/>
    /// </summary>
    public class QueueCallerLeaveEvent : QueueEvent
    {
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public string Position { get; set; }

        public QueueCallerLeaveEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}