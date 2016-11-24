namespace AsterNET.Manager.Event
{
    /// <summary>
    ///     A LogChannelEvent is triggered when logging is turned on or off.<br />
    ///     It is implemented in logger.c<br />
    /// </summary>
    public class LogChannelEvent : ManagerEvent
    {
        private string reason;
        private int reasonCode;

        public LogChannelEvent(ManagerConnection source)
            : base(source)
        {
        }

        /// <summary>
        ///     Get/Set if logging has been enabled or disabled.
        ///     <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        ///     Get the textual representation of the reason for disabling logging.
        ///     <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public string Reason
        {
            get { return reason; }
            set
            {
                reason = "";
                reasonCode = 0;

                if (string.IsNullOrEmpty(value))
                    return;

                int spaceIdx;

                if ((spaceIdx = value.IndexOf(' ')) <= 0)
                    spaceIdx = value.Length;
                int.TryParse(value.Substring(0, spaceIdx), out reasonCode);
                if (value.Length > spaceIdx + 3)
                    reason = value.Substring(spaceIdx + 3, value.Length - spaceIdx + 3);
            }
        }

        /// <summary>
        ///     Get the reason code for disabling logging.
        /// </summary>
        public int ReasonCode
        {
            get { return reasonCode; }
        }
    }
}