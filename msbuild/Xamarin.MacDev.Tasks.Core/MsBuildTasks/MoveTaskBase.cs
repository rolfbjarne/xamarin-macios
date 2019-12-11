#if WINDOWS
namespace Microsoft.Build.Tasks
{
	public abstract class MoveTaskBase : Move
	{
		public string SessionId { get; set; }
	}
}
#endif // WINDOWS
