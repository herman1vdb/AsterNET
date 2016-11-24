namespace AsterNET.Manager.Event
{
	/// <summary>
	/// A LeaveEvent is triggered when a channel leaves a queue.<br/>
	/// It is implemented in apps/app_queue.c
    /// 
    /// <b>Removed since : </b> <see href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+12+Documentation" target="_blank" alt="Asterisk 12 wiki docs">Asterisk 12</see>.<br/>/// 
	/// </summary>
	public class LeaveEvent : QueueEvent
	{
		public LeaveEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}