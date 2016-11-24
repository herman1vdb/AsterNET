namespace AsterNET.Manager.Event
{
    /// <summary>
    ///     Abstract base class for several agent related events.
    /// </summary>
    public abstract class AbstractAgentEvent : AbstractAgentVariables
    {
        public AbstractAgentEvent(ManagerConnection source)
            : base(source)
        {
        }

        /// <summary>
        ///     Get/Set the name of the queue.
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public string Queue { get; set; }

        /// <summary>
        ///     Get/Set the name of the member's interface.
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string Member { get; set; }

        /// <summary>
        ///     Get/Set the name of the member's interface.
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string MemberName { get; set; }
    }
}