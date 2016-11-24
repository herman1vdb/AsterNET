namespace AsterNET.Manager.Event
{
    /// <summary>
    /// <b>Removed since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.<br/>/// 
    /// </summary>
    internal class MasqueradeEvent : ManagerEvent
    {
        public string Clone { get; set; }

        public string CloneState { get; set; }

        public string Original { get; set; }

        public string OriginalState { get; set; }

        #region Constructor - MasqueradeEvent(ManagerConnection source)

        public MasqueradeEvent(ManagerConnection source)
            : base(source)
        {
        }

        #endregion
    }
}