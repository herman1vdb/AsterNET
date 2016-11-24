namespace AsterNET.Manager.Event
{
    /// <summary>
    ///     A MeetMeJoinEvent is triggered if a channel joins a meet me conference.<br />
    ///     It is implemented in apps/app_meetme.c
    /// </summary>
    public class MeetmeJoinEvent : AbstractMeetmeEvent
    {
        public MeetmeJoinEvent(ManagerConnection source)
            : base(source)
        {
        }
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string CallerIdNum { get; set; }
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.
        /// </summary>
        public string CallerIdName { get; set; }
    }
}