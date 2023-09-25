namespace Lib.Queue;

/// <summary>
/// Queue message interface.
/// </summary>
public interface IMessage
{
    /// <summary>
    /// Id of the message.
    /// </summary>
    public Guid Id { get; set; }
}
