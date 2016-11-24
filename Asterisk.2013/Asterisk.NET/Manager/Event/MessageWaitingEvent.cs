namespace AsterNET.Manager.Event
{
    /// <summary>
    ///     A MessageWaitingEvent is triggered when someone leaves voicemail.<br />
    ///     It is implemented in apps/app_voicemail.c
    /// </summary>
    public class MessageWaitingEvent : ManagerEvent
    {
        public MessageWaitingEvent(ManagerConnection source)
            : base(source)
        {
        }

        /// <summary>
        ///     Get/Set the name of the mailbox that has waiting messages.<br />
        ///     <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        ///     The name of the mailbox is of the form numberOfMailbox@context, e.g. 1234@default.
        /// </summary>
        public string Mailbox { get; set; }

        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        ///     Get/Set the number of new messages in the mailbox.
        /// </summary>
        public int Waiting { get; set; }

        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        ///     Get/Set the number of new messages in this mailbox.
        /// </summary>
        public int New { get; set; }

        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        ///     Get/Set the number of old messages in this mailbox.
        /// </summary>
        public int Old { get; set; }
    }
}