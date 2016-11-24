namespace AsterNET.Manager.Event
{
    public class MeetmeTalkRequestEvent : AbstractMeetmeEvent
    {
        public MeetmeTalkRequestEvent(ManagerConnection source)
            : base(source)
        {
        }
        /// <summary>
        /// <b>Available since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+11+Documentation" target="_blank" alt="Asterisk 11 wiki docs">Asterisk 11</see>.
        /// </summary>
        public bool Status { get; set; }
    }
}