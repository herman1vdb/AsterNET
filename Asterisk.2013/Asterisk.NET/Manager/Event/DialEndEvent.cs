namespace AsterNET.Manager.Event
{
    /// <summary>
    /// A dial begin event is triggered whenever when a dial action has completed.<br/>
    /// </summary>
	public class DialEndEvent : DialEvent
    {
        /// <summary>
        /// Creates a new DialEndEvent.
        /// </summary>
        public DialEndEvent(ManagerConnection source)
			: base(source)
		{
        }
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+13+Documentation" target="_blank" alt="Asterisk 13 wiki docs">Asterisk 13</see>.
        /// </summary>
        public string Forward { get; set; }
    }
}