namespace AsterNET.Manager.Event
{
    /// <summary>
    ///     A MeetMeLeaveEvent is triggered if a channel leaves a meet me conference.<br />
    ///     It is implemented in apps/app_meetme.c
    /// </summary>
    public class MeetmeLeaveEvent : AbstractMeetmeEvent
    {
        public MeetmeLeaveEvent(ManagerConnection source)
            : base(source)
        {
        }
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public string CallerIdNum { get; set; }
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public string CallerIdName { get; set; }
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public long Duration { get; set; }
    }
}