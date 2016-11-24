namespace AsterNET.Manager.Event
{
    /// <summary>
    /// A QueueCallerJoinEvent is triggered when a channel joins a queue.<br/>
    /// </summary>
    public class QueueCallerJoinEvent : QueueEvent
    {
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public string Position { get; set; }

        public QueueCallerJoinEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}