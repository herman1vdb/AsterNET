namespace AsterNET.Manager.Event
{
    /// <summary>
    ///     A HoldedCallEvent is triggered when a channel is put on hold.<br />
    ///     It is implemented in res/res_features.c
    /// </summary>
    public class HoldedCallEvent : ManagerEvent
    {
        public HoldedCallEvent(ManagerConnection source)
            : base(source)
        {
        }

        /// <summary>
        ///     Get/Set the unique id of the channel that put the other channel on hold.
        ///     <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public string UniqueId1 { get; set; }

        /// <summary>
        ///     Get/Set the unique id of the channel that has been put on hold.
        ///     <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public string UniqueId2 { get; set; }

        /// <summary>
        ///     Get/Set the name of the channel that put the other channel on hold.
        ///     <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public string Channel1 { get; set; }

        /// <summary>
        ///     Get/Set the name of the channel that has been put on hold.
        ///     <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public string Channel2 { get; set; }
    }
}